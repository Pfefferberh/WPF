﻿using _16_MVVM.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace _16_MVVM.ViewModel.Helpers
{
    public class AccuWeatherHelper
    {
        public const string BASE_URL = "http://dataservice.accuweather.com/";
        public const string API_KEY = "6dHGPx5ak9768THc8GvoYtbKSMv8Gpky";
        public const string AUTOCOMPLETE_ENDPOINT = "locations/v1/cities/autocomplete?apikey={0}&q={1}";
        public const string CURRENT_CONDITIONS_ENDPOINT = "currentconditions/v1/{0}?apikey={1}";
        public static async Task<List<City>> GetCities(string query)
        {
            List<City> cities = new List<City>();
            string url = BASE_URL + String.Format(AUTOCOMPLETE_ENDPOINT, API_KEY, query);
            using (HttpClient client = new HttpClient())
            {
                var responce = await client.GetAsync(url);
                string json = await responce.Content.ReadAsStringAsync(); 
                cities = JsonConvert.DeserializeObject<List<City>>(json);
            }
            return cities;
        }
        public static async Task<CurrentConditions> GetCurrentConditions(string locationKey)
        {
            CurrentConditions currentConditions = new CurrentConditions();
            string url = BASE_URL + String.Format(CURRENT_CONDITIONS_ENDPOINT, locationKey, API_KEY);
            using (HttpClient client = new HttpClient())
            {
                var responce = await client.GetAsync(url);
                string json = await responce.Content.ReadAsStringAsync(); 
                currentConditions = JsonConvert.DeserializeObject<List<CurrentConditions>>(json)[0];  
            }
            return currentConditions;
        }
    }
}
