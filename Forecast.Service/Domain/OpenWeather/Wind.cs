using Newtonsoft.Json;

namespace Forecast.Service.Domain.OpenWeather
{
    public class Wind
    {
        [JsonConstructor]
        public Wind(
            [JsonProperty("speed")] int speed,
            [JsonProperty("deg")] int deg
        )
        {
            this.Speed = speed;
            this.Deg = deg;
        }

        [JsonProperty("speed")]
        public int Speed { get; }

        [JsonProperty("deg")]
        public int Deg { get; }
    }
}
