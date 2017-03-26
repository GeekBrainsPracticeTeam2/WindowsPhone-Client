using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace WindowsUWP.models
{
    public class TotalStatis
    {
        public int siteId { get; set; }
        public List<Person> statistics { get; set; }

        public string siterUrl
        {
            get
            {
                return GetSiteUrl();
            }
            protected set
            {

            }
        }

        public TotalStatis()
        {

        }

        public string GetSiteUrl()
        {
            try
            {
                using (var db = new DBDictionary())
                {
                    var url = db.Sites.Find(siteId);
                    return url.Url;
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
