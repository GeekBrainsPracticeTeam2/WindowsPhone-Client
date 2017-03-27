using System;
using System.Collections.Generic;

namespace WindowsUWP.models
{
    public struct stat
    {
        public DateTime date;
        public List<PersonStats> personsStats;
    }

    public class DailyStatistics
    {
        public int siteId { get; set; }
        public List<stat> statistics { get; set; }
    }
}
