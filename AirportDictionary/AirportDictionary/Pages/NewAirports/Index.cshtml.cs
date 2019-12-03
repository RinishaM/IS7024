using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AirportDictionary.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AirportDictionary.Pages.NewAirports
{
    public class IndexModel : PageModel
    {
        private readonly IHostingEnvironment _environment;

        public IndexModel(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public IList<AirportAddition> AirportAddition = new List<AirportAddition>();
        public void OnGet()
        {
            string line;
            string path = Path.Combine(_environment.ContentRootPath, "AirportAddition.txt");
            StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                AirportAddition ad = new AirportAddition();
                ad.airportName = data[0];
                ad.airportType = data[1];
                ad.city = data[2];
                ad.state = (data[3]);
                ad.country = data[4];
                ad.elevation = double.Parse(data[5]);
                AirportAddition.Add(ad);
            }
            file.Close();
        }
    }
}
