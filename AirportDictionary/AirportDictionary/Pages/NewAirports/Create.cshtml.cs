using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AirportDictionary.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AirportDictionary.Pages.NewAirports
{
    public class CreateModel : PageModel
    {
        private readonly IHostingEnvironment _environment;

        public CreateModel(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AirportAddition AirportAddition { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            string addition = AirportAddition.airportName + "," + AirportAddition.airportType + "," + AirportAddition.city + ","
            + AirportAddition.state + "," + AirportAddition.country + "," + AirportAddition.elevation;
            string path = Path.Combine(_environment.ContentRootPath, "AirportAddition.txt");

            System.IO.File.AppendAllText(path, addition + Environment.NewLine);

            return RedirectToPage("./Index");
        }
    }
}