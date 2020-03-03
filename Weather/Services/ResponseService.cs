using System;
using System.IO;
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
    }
}
