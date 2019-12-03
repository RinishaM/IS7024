using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AirportDictionary.Models;

namespace AirportDictionary.Models
{
    public class AirportDictionaryContext : DbContext
    {
        public AirportDictionaryContext (DbContextOptions<AirportDictionaryContext> options)
            : base(options)
        {
        }

        public DbSet<AirportDictionary.Models.AirportJson> AirportJson { get; set; }

        public DbSet<AirportDictionary.Models.AirportAddition> AirportAddition { get; set; }
    }
}
