using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportDictionary.Models
{
    public class AirportJson
    {

        public int ID { get; set; }

        public string Continent { get; set; }


        //public string Coordinates { get; set; }


        public long ElevationFeet { get; set; }


        //public string GpsCode { get; set; }


       // public string Ident { get; set; }


       // public string IsoCountry { get; set; }


       // public string IsoRegion { get; set; }


        public string LocalCode { get; set; }


        public string Municipality { get; set; }


        public string Name { get; set; }


        public string Type { get; set; }

        public string Country { get; set; }

        public long GeoNameId { get; set; }

        public string SubCountry { get; set; }
    }
}
