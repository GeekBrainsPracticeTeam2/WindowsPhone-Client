using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsUWP.models;

namespace WindowsUWP.Json
{
    // TODO сделать работу с JSON
    class JsonHelper
    {
        WebRequest request;
        WebResponse response;

        public List<Person> GetAllPersons()
        {
            return new List<Person>();
        }

        public DateTime GetDateLustUpdate(string tableName)
        {
            return DateTime.Now;
        }

        public List<Site> GetAllSites()
        {
            return new List<Site>();
        }

        public Person GetPerson(int id)
        {
            return new Person();
        }

        public Site GetSite(int id)
        {
            return new Site();
        }

    }
}
