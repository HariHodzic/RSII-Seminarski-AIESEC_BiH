﻿using AiesecBiH.Model.Extensions;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp
{
    public class APIService
    {
        public string _route = null;
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static Model.Response.MemberLL LoggedUser { get; set; }

#if DEBUG
        private string _apiUrl = "http://localhost:11848/api";
#endif
#if RELEASE
#endif

        public APIService(string route)
        {
            _route = route;
        }


        public async Task<T> Get<T>(object search = null, string actionName=null)
        {
            try
            {   
                var url = $"{_apiUrl}/{_route}";
                if (actionName != null)
                {
                    url += "/" + actionName;
                }
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == (int)System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešan unos podataka ili nemate akaunt!", "OK");
                }
                if (ex.Call.Response.StatusCode ==(int) System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autorizovani.", "OK");
                    return default(T);
                }
                throw ex;
            }
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> GetByUsername<T>(object username)
        {
            var url = $"{_apiUrl}/{_route}/?username={username}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";
            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Wrong username or password!", "OK");
                return default(T);
            }
        }
        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Delete<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}";
            return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
        }
    }
}