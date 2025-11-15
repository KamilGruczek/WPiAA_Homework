using System.Text.Json.Serialization;

namespace Facade.ViewModels
{
    internal class WeatherMain
    {
        [JsonPropertyName("temp")]
        public double Temp { get; set; }
        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
        [JsonPropertyName("temp_min")]
        public double TempMin { get; set; }
        [JsonPropertyName("temp_max")]
        public double TempMax { get; set; }
    }
}
