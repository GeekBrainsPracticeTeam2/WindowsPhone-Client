using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WindowsUWP.models;
using System.IO;

namespace WindowsUWP.Helpers
{
    // TODO сделать работу с JSON
    class JsonHelper
    {
        WebRequest request;
        WebResponse response;

        const string serverUrl = "http://localhost:8080/WebAppRest/";

        /// <summary>
        /// Специальная структура для упрощения получения даты
        /// </summary>
        private struct dateT
        {
            public DateTime LastUpdate { get; set; }
        }

        public async Task<DateTime> GetSiteLustUpdateDateAsync(string tableName)
        {
            string token = "GetSitesUpdateDate";
            string respone = await RequestAsync(token);

            var dat = JsonConvert.DeserializeObject<dateT>(respone);

            return dat.LastUpdate;
        }

        public async Task<DateTime> GetPersonLustUpdateDateAsync(string tableName)
        {
            string token = "GetPersonUpdateDate";
            string respone = await RequestAsync(token);

            var dat = JsonConvert.DeserializeObject<dateT>(respone);

            return dat.LastUpdate;
        }

        public async Task<List<Site>> GetSitesAsync()
        {
            string token = "GetSites";
            string respone = await RequestAsync(token);

            dynamic stats = JsonConvert.DeserializeObject(respone);
            List<Site> dat = JsonConvert.DeserializeObject<List<Site>>(stats.data.ToString());

            return dat;
        }

        public async Task<List<Person>> GetPersonAsync(int id)
        {
            string token = "GetPersons";
            string respone = await RequestAsync(token);

            dynamic stats = JsonConvert.DeserializeObject(respone);
            List<Person> dat = JsonConvert.DeserializeObject<List<Person>>(stats.data.ToString());

            return dat;
        }

        public async Task<List<TotalStatis>> GetTotalstatisticsAsync()
        {
            string token = "GetSiteStatistic";
            string respone = await RequestAsync(token);

            dynamic stats = JsonConvert.DeserializeObject(respone);
            var dat = JsonConvert.DeserializeObject<List<TotalStatis>>(stats.data.ToString());

            return dat;
        }

        public async Task<List<DailyStatistics>> GetDailyStatisticsAsync(string beginDate, string endaDate)
        {
            string token = $"GetStatisticForPeriod?StartDate={beginDate}&EndDate={endaDate}";
            string respone = await RequestAsync(token);

            dynamic stats = JsonConvert.DeserializeObject(respone);
            var dat = JsonConvert.DeserializeObject<List<DailyStatistics>>(stats.data.ToString());

            return dat;
        }


        /// <summary>
        /// Запрос к сайту с получением Json строки
        /// </summary>
        /// <param name="token">параметр запроса</param>
        /// <returns></returns>
        private static async Task<string> RequestAsync(string token)
        {
            string responseAnswer = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Format($"{serverUrl}{token}"));
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    responseAnswer = reader.ReadToEnd();
                }
            }
            return responseAnswer;
        }
    }
}
