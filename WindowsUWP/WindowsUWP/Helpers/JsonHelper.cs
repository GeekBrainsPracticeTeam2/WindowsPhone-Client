using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WindowsUWP.models;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsUWP.Helpers
{
    // TODO сделать работу с JSON
    static class JsonHelper
    {
        const string serverUrl = "http://localhost:8080/WebAppRest/";

        /// <summary>
        /// Специальная структура для упрощения получения даты
        /// </summary>
        private struct dateT
        {
            public DateTime LastUpdate { get; set; }
        }

        /// <summary>
        /// Получение даты последнего обновления справочника Сайты
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static async Task<DateTime> GetSiteLustUpdateDateAsync(string tableName)
        {
            string token = "GetSitesUpdateDate";
            string respone = await RequestAsync(token);

            var dat = JsonConvert.DeserializeObject<dateT>(respone);

            return dat.LastUpdate;
        }

        /// <summary>
        /// Получение последней даты обновления справочников Персоны
        /// </summary>
        /// <returns></returns>
        public static async Task<DateTime> GetPersonLustUpdateDateAsync()
        {
            string token = "GetPersonUpdateDate";
            string respone = await RequestAsync(token);

            var dat = JsonConvert.DeserializeObject<dateT>(respone);

            return dat.LastUpdate;
        }

        /// <summary>
        /// Получение справочника Сайты
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Site>> GetSitesAsync()
        {
            string token = "GetSites";
            string respone = await RequestAsync(token);

            dynamic stats = JsonConvert.DeserializeObject(respone);
            List<Site> dat = JsonConvert.DeserializeObject<List<Site>>(stats.data.ToString());

            return dat;
        }

        /// <summary>
        /// Получение Справочника Персоны
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Person>> GetPersonAsync()
        {
            string token = "GetPersons";
            string respone = await RequestAsync(token);

            dynamic stats = JsonConvert.DeserializeObject(respone);
            List<Person> dat = JsonConvert.DeserializeObject<List<Person>>(stats.data.ToString());

            return dat;
        }

        /// <summary>
        /// Получение общей статистики по сайтам
        /// </summary>
        /// <returns></returns>
        public static async Task<List<TotalStatis>> GetTotalstatisticsAsync()
        {
            string token = "GetSiteStatistic";
            string respone = await RequestAsync(token);

            dynamic stats = JsonConvert.DeserializeObject(respone);
            var dat = JsonConvert.DeserializeObject<List<TotalStatis>>(stats.data.ToString());

            return dat;
        }

        /// <summary>
        /// Получение статистики по сайтам за определённый период
        /// </summary>
        /// <param name="beginDate">Дата начала</param>
        /// <param name="endaDate">Дата окончания</param>
        /// <returns></returns>
        public static async Task<List<DailyStatistics>> GetDailyStatisticsAsync(string beginDate, string endaDate)
        {
            string token = $"GetStatisticForPeriod?StartDate={beginDate}&EndDate={endaDate}";
            string respone = await RequestAsync(token);

            string pat = "\"" + @"\d{4}-\d{2}-\d{2}" + "\"";

            if (!Regex.IsMatch(respone, pat)) // приходящая дата не имеет кавычек, поэтому необходимо их добавить
            {
                string pattern = @"\d{4}-\d{2}-\d{2}";
                string replacement = "\"$&\"";
                respone = Regex.Replace(respone, pattern, replacement);
            }

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
