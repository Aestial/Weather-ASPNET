using System;
using System.Text.Json;

namespace Weather.Models
{
    public class WeatherResponse
    {        
        public Coord Coord { get; set; }
        public Weather Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public float Visibility { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);

        public WeatherResponse()
        {
        }
    }
    public class Coord
    {
        public float Lon { get; set; }
        public float Lat { get; set; }
    }
    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
    public class Main
    {
        public float Temp { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
        public float Temp_min { get; set; }
        public float Temp_max { get; set; }
    }    
}
