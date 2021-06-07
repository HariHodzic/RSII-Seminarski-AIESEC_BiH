using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AiesecBiH.Model.Extensions;
using Flurl.Http;
using Flurl.Util;

namespace AiesecBiH.WinUI
{
    public class APIService
    {
        public string _route = null;

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

            var result = await url.GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            return await url.PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Update<T>(object id,object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.PutJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Delete<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.DeleteAsync().ReceiveJson<T>();
        }
        public async void LoadComboBox<T>(APIService service, ComboBox cmb, string displayMember, int? id=null)
        {
            var source = await service.Get<List<T>>();
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
