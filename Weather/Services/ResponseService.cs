using System;
using System.IO;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Weather.Models;

namespace Weather.Services
{
    public class ResponseService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        public ResponseService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "response.json"); }
        }

        public WeatherResponse GetResponse()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<WeatherResponse>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public WeatherResponse GetGeolocationResponse(float lon, float lat)
        {
            string appId = "9cf2362528f766642106dbde08fed2de";
            string url = String.Format("http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units=metric&APPID={2}",
                lat.ToString(), lon.ToString(), appId);
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(url);
                return JsonSerializer.Deserialize<WeatherResponse>(json,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });                
            }
        }
    }
}
