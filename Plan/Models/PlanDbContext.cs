using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Plan.Models
{
    public class PlanDbContext : DbContext
    {
        public DbSet<Lekcja> Lekcje { set; get; }
        public DbSet<Grupa> Grupy { set; get; }
        public DbSet<Przedmiot> Przedmioty { set; get; }

    }
}