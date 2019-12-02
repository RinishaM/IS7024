using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AirportDictionary.Models;
using AirportDetails;
using System.Net;
using CityDetails;

namespace AirportDictionary.Controllers
{
    [Route("api/Airport/[controller]")]
    [ApiController]
    public class AirportJsonsController : ControllerBase
    {


        // GET: api/AirportJsons
        [HttpGet]
        public ActionResult<IEnumerable<AirportJson>> GetAirportJson()
        {
            List<AirportJson> airportsOfRequiredCity = new List<AirportJson>();
            string airportJson = GetData("https://pkgstore.datahub.io/core/airport-codes/airport-codes_json/data/552f9a534537e5a2f7a8b0584dad7e77/airport-codes_json.json");
            Airport[] allAirport = Airport.FromJson(airportJson);
            string cityJson = GetData("https://pkgstore.datahub.io/core/world-cities/world-cities_json/data/5b3dd46ad10990bca47b04b4739a02ba/world-cities_json.json");
            City[] allCity = City.FromJson(cityJson);

            foreach (Airport airport in allAirport)
            {

                AirportJson aj = new AirportJson();
                aj.IsoCountry = airport.IsoCountry;
                aj.Coordinates = airport.Coordinates;
                aj.GpsCode = airport.GpsCode;
                aj.IsoRegion = airport.IsoRegion;
                airportsOfRequiredCity.Add(aj);

            }


            return airportsOfRequiredCity;
        }
        public string GetData(string endpoint)
        {
            string downloadedJson;
            using (WebClient webClient = new WebClient())
            {
                downloadedJson = webClient.DownloadString(endpoint);
            }
            return downloadedJson;
        }


    }
}
