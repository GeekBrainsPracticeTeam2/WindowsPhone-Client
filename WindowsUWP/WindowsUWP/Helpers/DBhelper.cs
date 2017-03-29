using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUWP.Helpers
{
    public static class DBhelper
    {
        /// <summary>
        /// Получение Имени персоны по его ID
        /// </summary>
        /// <param name="id">ID искомой персоны</param>
        /// <returns></returns>
        public static string GetNamePerson(int id)
        {
            try
            {
                using (var db = new DBDictionary())
                {
                    var person = db.Persons.Find(id);
                    return person.name;
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Source);
                return $"Имя персоны с id {id} неизвестно";
            }
        }

        /// <summary>
        /// Получение Url адреса сайта по его ID
        /// </summary>
        /// <param name="id">ID сайта</param>
        /// <returns></returns>
        public static string GetSiteUrl(int id)
        {
            try
            {
                using (var db = new DBDictionary())
                {
                    var url = db.Sites.Find(id);
                    return url.name;
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Source);
                return "Сайт неизвестен, возможно вы не обновили библиотеку?";
            }

        }
    }
}
