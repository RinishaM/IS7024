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

            foreach (City city in allCity)
            {
                //if(city.Subcountry== "Ohio")
                //{
                    foreach (Airport airport in allAirport)
                    {
                        if (airport.Municipality != null)
                        {
                            if (city.Name.ToLower() == airport.Municipality.ToLower())
                            {
                                AirportJson aj = new AirportJson();
                                aj.Continent = airport.Continent;
                                aj.Country = city.Country;
                                aj.SubCountry = city.Subcountry;
                                aj.Municipality = airport.Municipality;
                                aj.GeoNameId = city.GeoNameID;
                                aj.Name = airport.Name;
                                aj.Type = airport.Type;
                                aj.LocalCode = airport.LocalCode;
                                aj.ElevationFeet = airport.ElevationFeet;
                                airportsOfRequiredCity.Add(aj);
                            }
                        }
                    //}

            }
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
