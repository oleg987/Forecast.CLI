using Forecast.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather
{
    public class OpenWeatherSettings : IWeatherServiceSettings
    {
        public string Key { get; }
        public string BaseUrl { get; }

        public OpenWeatherSettings(string key, string baseUrl)
        {
            Key = key;
            BaseUrl = baseUrl;
        }
    }
}
