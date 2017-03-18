﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUWP.models
{
    class LastUpdate
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
