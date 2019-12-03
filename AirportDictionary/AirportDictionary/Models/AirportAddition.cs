using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace AirportDictionary.Models
{
    public class AirportAddition
    {
        public int Id { get; set; }
        [Display(Name = "Airport Name")]
        public string airportName { get; set; }
        [Display(Name = "Airport Type")]
        public string airportType { get; set; }
        [Display(Name = "City")]
        public string city { get; set; }
        [Display(Name = "State")]
        public string state { get; set; }
        [Display(Name = "Country")]
        public string country { get; set; }
        [Display(Name = "Elevation")]
        public double elevation { get; set; }
    }
}