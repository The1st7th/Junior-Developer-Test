// -----------------------------------------------------------------------
// 
// <copyright file="WeatherApiService.cs" company="Provoke Solutions">
// 
// Copyright (c) Provoke Solutions. All rights reserved.
// 
// </copyright>
// 
// -----------------------------------------------------------------------
namespace JuniorDevTestFunctionApp.Services
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Configuration;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Class WeatherApiService.
    /// </summary>
    public static class WeatherApiService
    {
        /// <summary>
        /// The configuration.
        /// TODO: We need an API Key for this service's configuration. One of our developers mentioned we can get a key here: https://openweathermap.org/
        /// TODO: Once we have a key, we need to add it to the application's configuration.
        /// </summary>
        private static readonly WeatherServiceConfiguration Configuration =
            ApplicationConfiguration.Configuration.GetSection("WeatherApiConfiguration")
                .Get<WeatherServiceConfiguration>();

        /// <summary>
        /// The client
        /// </summary>
        private static readonly HttpClient Client = new HttpClient();

        /// <summary>
        /// Gets the weather.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>Task JObject.</returns>
        public static async Task<JObject> GetWeather(string query)
        {

            WeatherServiceConfiguration urlobject = new WeatherServiceConfiguration();
            String S1 = urlobject.WeatherUrlBase;
            String S2 = urlobject.Key;
            HttpRequestMessage webRequest = new HttpRequestMessage()
            {

                //RequestUri = new Uri("http://api.openweathermap.org/data/2.5/weather?q=${query}&appid=5ca126d85a3da75eacf46cca04a6f2c1"),
                RequestUri = new Uri($"{S1}?q={query}&appid={S2}"),
                Method =  HttpMethod.Post
            };

            var response = await Client.SendAsync(webRequest);
            Console.WriteLine(response);
            Console.WriteLine("hello");
            
            response.EnsureSuccessStatusCode();
            Console.WriteLine("hello");

            return await response.Content.ReadAsAsync<JObject>();
        }
    }
}
