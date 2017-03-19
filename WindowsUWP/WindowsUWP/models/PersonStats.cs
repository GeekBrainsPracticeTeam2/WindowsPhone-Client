using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUWP.models
{
    public class PersonStats
    {
        public DateTime Date { get; set; }
        public int Rank { get; set; }

        public PersonStats(DateTime date, int rankCount)
        {
            Date = date;
            Rank = rankCount;
        }
    }
}
