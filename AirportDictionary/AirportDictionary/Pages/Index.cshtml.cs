using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using CityDetails;
using AirportDetails;
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

            SearchCompleted = false;

        }
        [BindProperty]
        public string Search { get; set; }
        public bool SearchCompleted { get; set; }
        List<Airport> airportsOfRequiredCity = new List<Airport>();
        City newCity = new City();

        //string requiredCity = "Cincinnati";
        public void OnPost()
        {
            string cityJson = GetData("https://pkgstore.datahub.io/core/world-cities/world-cities_json/data/5b3dd46ad10990bca47b04b4739a02ba/world-cities_json.json");
            City[] allCity = City.FromJson(cityJson);
            string airportJson = GetData("https://pkgstore.datahub.io/core/airport-codes/airport-codes_json/data/552f9a534537e5a2f7a8b0584dad7e77/airport-codes_json.json");
            Airport[] allAirport = Airport.FromJson(airportJson);
            foreach (Airport airport in allAirport)
            { 
                if (airport.Municipality != null)
                { 
                if (airport.Municipality.ToLower() == Search.ToLower())
                {
                    airportsOfRequiredCity.Add(airport);
                }
                }
            }
            foreach (City city in allCity)
            {
                if (city.Name.ToLower() == Search.ToLower())
                {
                    newCity = city;
                }
            }
            ViewData["RequiredAirports"] = airportsOfRequiredCity;
            ViewData["City"] = newCity;
            SearchCompleted = true;
        }

        public string GetData(string endpoint)
        {
            string downloadedJson;
            using (WebClient webClient = new WebClient())
            {
                downloadedJson = webClient.DownloadString(endpoint); ;
            }
            return downloadedJson;
        }
    }
}
