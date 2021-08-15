using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.DataModels;

namespace Demo.UI.Services
{
    interface IForecastService
    {
        Task<WeatherForecastModel> getForecast();
    }
}
