using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUWP.models
{
    class DailyStatistics
    {
        public struct stat
        {
            public DateTime date;
            public List<PersonStats> personsStats;
        }

        public int siteId { get; set; }
        public List<stat> statistics { get; set; }
    }
}
