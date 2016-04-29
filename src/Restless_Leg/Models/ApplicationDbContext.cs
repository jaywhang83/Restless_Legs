using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Restless_Legs.Models;

namespace Restless_Leg.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Posting> Postings { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}
