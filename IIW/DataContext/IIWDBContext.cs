using IIW.Models.ProjectModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IIW.DataContext
{
    public class IIWDBContext:DbContext
    {
        public IIWDBContext() : base("SQL") { }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Attractions> Attractions { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Restaurants> Restaurants { get; set; }
    }
}