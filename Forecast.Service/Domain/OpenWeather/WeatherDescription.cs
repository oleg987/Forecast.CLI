using Newtonsoft.Json;

namespace Forecast.Service.Domain.OpenWeather
{
    public class WeatherDescription
    {
        [JsonConstructor]
        public WeatherDescription(
            [JsonProperty("id")] int id,
            [JsonProperty("main")] string main,
            [JsonProperty("description")] string description,
            [JsonProperty("icon")] string icon
        )
        {
            this.Id = id;
            this.Main = main;
            this.Description = description;
            this.Icon = icon;
        }

        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("main")]
        public string Main { get; }

        [JsonProperty("description")]
        public string Description { get; }

        [JsonProperty("icon")]
        public string Icon { get; }
    }
}
