using AutoMapper;
using Forecast.Service.Domain;
using Forecast.Service.Domain.OpenWeather;
using Forecast.Service.Mapping;
using Forecast.Service.Services.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather
{
    public class OpenWeatherService : IWeatherService
    {
        protected HttpClient _client;
        #region
        protected IMapper _mapper;
        #endregion
        public IWeatherServiceSettings Settings { get; }


        public OpenWeatherService(IWeatherServiceSettings settings)
        {
            Settings = settings;
            _client = new HttpClient();
            #region
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new WeatherForecastProfile())));
            #endregion
        }

        public virtual WeatherForecast GetForecast(IWeatherQuery query)
        {
            // TODO: Validate query.

            var response = _client.GetAsync(Settings.BaseUrl + $"appid={Settings.Key}" + query.GetQueryString()).Result;

            OpenWeatherResponse weatherResponse = null;

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;

                weatherResponse = JsonConvert.DeserializeObject<OpenWeatherResponse>(content); // TODO: Handle response parsing exception.
            }
            else
            {
                throw new Exception($"Status: {response.StatusCode}"); // TODO: Create custom exception.
            }

            //var weather = new WeatherForecast();

            //weather.City = weatherResponse.CountryInfo.Country;
            //weather.Clouds = weatherResponse.Clouds.All;
            //weather.Date = DateTimeOffset.FromUnixTimeSeconds(weatherResponse.Date);

            //// Init other 12 properties. 
            #region
            var weather = _mapper.Map<WeatherForecast>(weatherResponse);
            #endregion
            return weather;
        }
    }
}
