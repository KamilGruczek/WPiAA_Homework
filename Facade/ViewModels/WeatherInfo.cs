using System.Text.Json.Serialization;

namespace Facade.ViewModels
{
    internal class WeatherInfo
    {
        [JsonPropertyName("weather")]
        public List<Weather> Weather { get; set; } = [];

        [JsonPropertyName("main")]
        public WeatherMain Main { get; set; }
    }
}
