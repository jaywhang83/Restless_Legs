using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace Restless_Leg.Models
{
    public class Restless_LegContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Posting> Postings { get; set; }
    }
}
