using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace Restless_Legs.Models
{
    public class Restless_LegDbContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Posting> Postings { get; set; }
    }
}
