using Demo.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Demo.UI.Services
{
    public class ForecastService : IForecastService
    {
        private readonly HttpClient httpClient;

        public ForecastService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }
        public async Task<WeatherForecastModel> getForecast()
        {
            //Call the api and retrieve the list of products.

            return await httpClient.GetFromJsonAsync<WeatherForecastModel>("https://www.metaweather.com/api/location/742676/");
        }
    }
}
