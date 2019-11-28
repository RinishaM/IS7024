﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using QuickTypeCity;

namespace AirportDictionary.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public JsonResult OnGet()
        {

                string cityJson = getJsonData("https://pkgstore.datahub.io/core/world-cities/world-cities_json/data/5b3dd46ad10990bca47b04b4739a02ba/world-cities_json.json");
                QuickTypeCity.Welcome[] allCity = QuickTypeCity.Welcome.FromJson(cityJson);

                

               

                string airportJson = getJsonData("https://pkgstore.datahub.io/core/airport-codes/airport-codes_json/data/552f9a534537e5a2f7a8b0584dad7e77/airport-codes_json.json");
                var allAirport = QuickTypeAirport.Airport.FromJson(airportJson);





                return new JsonResult(allCity);


            
        }

        private string getJsonData(string url)
        {
            using (var webClient = new System.Net.WebClient())
            {
                return webClient.DownloadString(url);


            }
            
        }

       
    }
        
    }
}
