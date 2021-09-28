using Newtonsoft.Json;
using System.Collections.Generic;

namespace Forecast.Service.Domain.OpenWeather
{
    public class OpenWeatherResponse
    {
        [JsonConstructor]
        public OpenWeatherResponse(
            [JsonProperty("coord")] Coordinates coord,
            [JsonProperty("weather")] List<WeatherDescription> weather,
            [JsonProperty("base")] string @base,
            [JsonProperty("main")] WeatherParams main,
            [JsonProperty("visibility")] int visibility,
            [JsonProperty("wind")] Wind wind,
            [JsonProperty("clouds")] Clouds clouds,
            [JsonProperty("dt")] int dt,
            [JsonProperty("sys")] CountryInfo sys,
            [JsonProperty("timezone")] int timezone,
            [JsonProperty("id")] int id,
            [JsonProperty("name")] string name,
            [JsonProperty("cod")] int cod
        )
        {
            this.Coord = coord;
            this.WeatherDescription = weather;
            this.Base = @base;
            this.WeatherParams = main;
            this.Visibility = visibility;
            this.Wind = wind;
            this.Clouds = clouds;
            this.Date = dt;
            this.CountryInfo = sys;
            this.Timezone = timezone;
            this.Id = id;
            this.Name = name;
            this.Cod = cod;
        }

        [JsonProperty("coord")]
        public Coordinates Coord { get; }

        [JsonProperty("weather")]
        public IReadOnlyList<WeatherDescription> WeatherDescription { get; }

        [JsonProperty("base")]
        public string Base { get; }

        [JsonProperty("main")]
        public WeatherParams WeatherParams { get; }

        [JsonProperty("visibility")]
        public int Visibility { get; }

        [JsonProperty("wind")]
        public Wind Wind { get; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; }

        [JsonProperty("dt")]
        public int Date { get; }

        [JsonProperty("sys")]
        public CountryInfo CountryInfo { get; }

        [JsonProperty("timezone")]
        public int Timezone { get; }

        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("cod")]
        public int Cod { get; }
    }
}
