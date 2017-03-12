using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WindowsUWP.models;

namespace WindowsUWP
{
    class RankContext: DbContext
    {
        public DbSet<LastUpdate> LastUpdates { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Site> Sites { get; set; }
    }
}
