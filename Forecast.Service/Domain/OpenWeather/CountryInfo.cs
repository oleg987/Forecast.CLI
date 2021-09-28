using Newtonsoft.Json;

namespace Forecast.Service.Domain.OpenWeather
{
    public class CountryInfo
    {
        [JsonConstructor]
        public CountryInfo(
            [JsonProperty("type")] int type,
            [JsonProperty("id")] int id,
            [JsonProperty("country")] string country,
            [JsonProperty("sunrise")] int sunrise,
            [JsonProperty("sunset")] int sunset
        )
        {
            this.Type = type;
            this.Id = id;
            this.Country = country;
            this.Sunrise = sunrise;
            this.Sunset = sunset;
        }

        [JsonProperty("type")]
        public int Type { get; }

        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("country")]
        public string Country { get; }

        [JsonProperty("sunrise")]
        public int Sunrise { get; }

        [JsonProperty("sunset")]
        public int Sunset { get; }
    }
}
