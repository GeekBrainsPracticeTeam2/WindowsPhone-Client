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
        public string PersonName { get; set; }
        public int Rank { get; set; }

        protected int personId;

        public TotalStatis(int personId, int rank)
        {
            this.personId = personId;
            this.Rank = rank;

            TakePersonName();
        }

        private void TakePersonName()
        {
            try
            {
                using (var db = new DBDictionary())
                {
                    var person = db.Persons.Find(personId);
                    PersonName = person.Name;
                }
            }
            catch(NullReferenceException e)
            {
                PersonName = "Имя неизвестно";
            }
        }

    }
}
