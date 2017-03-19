using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WindowsUWP.models;

namespace WindowsUWP
{
    // TODO Дописать работу с БД
    class DBDictionary: DbContext
    {
        public DbSet<LastUpdate> LastUpdates { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Site> Sites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Rank1.db");
        }
    }

    
}
