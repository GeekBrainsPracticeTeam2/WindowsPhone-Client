using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsUWP.models;
using Newtonsoft.Json.Linq;

namespace WindowsUWP.Helpers
{
    // TODO сделать работу с JSON
    class JsonHelper
    {
        WebRequest request;
        WebResponse response;

        string sample = "{ \"data\":[{\"siteId\":0,\"statistics\":[{\"person\":0,\"count\":5},{\"person\":1,\"count\":7},{\"person\":2,\"count\":14},{\"person\":3,\"count\":8},{\"person\":4,\"count\":27}]},{\"siteId\":1,\"statistics\":[{\"person\":0,\"count\":3},{\"person\":1,\"count\":10},{\"person\":2,\"count\":7},{\"person\":3,\"count\":10},{\"person\":4,\"count\":21}]}]}";
        string SAMPLE_JSON_TOTAL_STATISTICS = "{\"siteID\":0,\"statistics\":" +
                                              "[{\"person\":0,\"count\":5},{\"person\":1,\"count\":7},{\"person\":2,\"count\":14}," +
                                              "{\"person\":3,\"count\":8},{\"person\":4,\"count\":27}]}";
        string SAMPLE_JSON_UPDATE_STATUS = "{\"tables\":[{\"ID\":0,\"lu_date\":" +
                                           "\"2017-03-13 15:56:26\"},{\"ID\":1,\"lu_date\":\"2017-03-13 15:56:26\"}]}";
        string SAMPLE_JSON_SITES_DIR_UPDATE = "{\"data\":[{\"ID\":0,\"url\":" +
                                              "\"lenta.ru\"},{\"ID\":1,\"url\":\"vesti.ru\"},{\"ID\":2,\"url\":\"kp.ru\"}]}";
        string SAMPLE_JSON_NAMES_DIR_UPDATE = "{\"data\":[{\"ID\":0,\"name\":" +
                                              "\"Путин В.В.\"},{\"ID\":1,\"name\":\"Медведев Д.А.\"},{\"ID\":2,\"name\":\"Навальный ?.?.\"}]}";

        public void DeJson(string jstring)
        {
            
        }


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
