﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using eRestoran.Model;
using System.Windows.Forms;

namespace eRestoran.WinUI
{
     public class ApiService
    {
        private string _route = null;
        public ApiService(string route)
        {
            _route = route;
        }

        public static string Username { get; set; }
        public static string Password { get; set; }


        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste autentificirani");
                }
                throw;
            }
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            return await url.GetJsonAsync<T>();
        }
        public async Task<T> GetByName<T>(object name)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/name={name}";
            return await url.GetJsonAsync<T>();
        }
        public async Task<T> GetByDates<T>(object dateFrom,object dateTo)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/getByDates/{dateFrom}/{dateTo}";
            return await url.GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            return await url.PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Update<T>(int id, object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";
            return await url.PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> GetByKlijent<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/getByKlijent/{id}";
            return await url.GetJsonAsync<T>();
        }

        public async Task<T> GetByNarudzbe<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/GetByNarudzbe/{id}";
            return await url.GetJsonAsync<T>();
        }
    }
}
