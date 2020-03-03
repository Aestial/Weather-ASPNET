using System.Text.Json;
using System.Text.Json.Serialization;

namespace Weather.Models
{
    public class WeatherResponse
    {
        [JsonPropertyName("coord")]
        public Geolocation Geo { get; set; }
        public Weather[] Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public float Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public Sys Sys { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);

        public WeatherResponse()
        {
        }
    }
}
