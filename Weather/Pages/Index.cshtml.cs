using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Weather.Models;
using Weather.Services;

namespace Weather.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public ResponseService ResponseService;
        public WeatherResponse WeatherResponse{ get; private set; }


        public IndexModel(ILogger<IndexModel> logger,
            ResponseService responseService)
        {
            _logger = logger;
            ResponseService = responseService;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (Request.Cookies["longitude"] != null
                && Request.Cookies["latitude"] != null)
            {
                float lon = float.Parse(Request.Cookies["longitude"]);
                float lat = float.Parse(Request.Cookies["latitude"]);
                WeatherResponse = ResponseService.GetGeolocationResponse(lon, lat);
            }            
        }   
    }
}
