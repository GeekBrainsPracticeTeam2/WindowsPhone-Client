using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUWP.models
{
    class Site
    {
        public int ID { get; set; }
        public string Url { get; set; }

        public Site() { }

        public Site(int id, string Url)
        {
            ID = id;
            this.Url = Url;
        }
    }
}
