using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AiesecBiH.Model.Extensions;
using AiesecBiH.Model.Response;
using Flurl.Http;
using Flurl.Util;

namespace AiesecBiH.WinUI
{
    public class APIService
    {
        public string _route = null;
        public static string Username { get; set; }
        public static string Password { get; set; }

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search=null)
         {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username,Password).GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                //var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();
                //var stringBuilder = new StringBuilder();
                //foreach (var error in errors)
                //{
                //    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                //}

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }
        public async Task<T> Update<T>(object id,object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Delete<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
        }

        public async Task<FileModel> Upload(MultipartFormDataContent request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            return await url.WithBasicAuth(Username, Password).PostMultipartAsync(mp=>mp.Add(request)).ReceiveJson<FileModel>();
        }
        public async System.Threading.Tasks.Task LoadComboBox<T>(ComboBox cmb, string displayMember, int? id=null)
        {
            var source = await this.Get<List<T>>();
            cmb.DataSource = source;
            cmb.ValueMember = "Id";
            cmb.DisplayMember = displayMember;
            if(id!=null)
              cmb.SelectedValue = id;
            else
            {
                cmb.SelectedIndex = -1;
            }
            
        }
    }
}
