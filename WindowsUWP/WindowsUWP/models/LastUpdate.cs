using System;

namespace WindowsUWP.models
{
    public class LastUpdate
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string TableName { get; set; }

        public LastUpdate() { }

        public LastUpdate(int ID, DateTime Date, string TableName)
        {
            this.ID = ID;
            this.Date = Date;
            this.TableName = TableName;
        }
    }
}
