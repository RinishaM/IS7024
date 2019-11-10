using System;
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

        public void OnGet()
        {

            using (var webClient = new System.Net.WebClient())
            {

                //IDictionary<long, QuickTypeCity.Welcome> allCities = new Dictionary<long, QuickTypeCity.Welcome>();

                string cityJson = webClient.DownloadString("https://pkgstore.datahub.io/core/world-cities/world-cities_json/data/5b3dd46ad10990bca47b04b4739a02ba/world-cities_json.json");
                QuickTypeCity.Welcome[] allCity = QuickTypeCity.Welcome.FromJson(cityJson);

                ViewData["Welcome"] = allCity;

                //foreach (QuickTypeCity.Welcome welcome in allCity)
                //{
                //    allCities.Add(welcome.Geonameid, welcome);

                //}

                // QuickTypeAirport.Airport[] allAirport = QuickTypeAirport.Airport.FromJson(airportJson);


                string airportJson = webClient.DownloadString("https://pkgstore.datahub.io/core/airport-codes/airport-codes_json/data/552f9a534537e5a2f7a8b0584dad7e77/airport-codes_json.json");
                var allAirport = QuickTypeAirport.Airport.FromJson(airportJson);

                //JSchema schema = JSchema.Parse(System.IO.File.ReadAllText("CitySchema.json"));
                //JObject jsonObject = JObject.Parse(cityJson);
                //IList<string> validationEvents = new List<string>();
                //if (jsonObject.IsValid(schema, out validationEvents))
                //{

                //}








            }
        }
    }
}
