using Forecast.Service.Services.Implementation.OpenWeather;
using Forecast.Service.Services.Implementation.OpenWeather.Queries;
using System;

namespace Forecast.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new OpenWeatherSettings("c16337ebad8860ce112d59b2d00ff139", @"http://api.openweathermap.org/data/2.5/weather?");
            var service = new OpenWeatherService(settings);
            var query = new QueryByCityId(698740);

            var decorated = new LangDacorator(new UnitsDecorator(query, "metric"), "ru");

            var weather = service.GetForecast(decorated);

            Console.WriteLine($"{weather.City}\n" +
                $"{weather.Temperature}");
        }
    }
}
