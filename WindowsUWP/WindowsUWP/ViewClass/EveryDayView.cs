using System;

namespace WindowsUWP.ViewClass
{
    class EveryDayView
    {
        public int siteId { get; set; }
        public int personId { get; set; }
        public DateTime date { get; set; }
        public int rank { get; set; }


        public EveryDayView(int siteId, int personId, DateTime date, int rank)
        {
            this.siteId = siteId;
            this.personId = personId;
            this.date = date;
            this.rank = rank;
        }
    }
}
