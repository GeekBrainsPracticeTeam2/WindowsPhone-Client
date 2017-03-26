using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUWP.models
{
    public class PersonStats
    {
        public int person { get; set; }
        public int count { get; set; }
        public string PersonName
        {
            get
            {
                if (PersonName == null)
                {
                    return TakePersonName();
                }
                return PersonName;
            }

            protected set
            {

            }
        }

        public PersonStats()
        {

        }

        private string TakePersonName()
        {
            try
            {
                using (var db = new DBDictionary())
                {
                    var person = db.Persons.Find(this.person);
                    PersonName = person.name;
                    return person.name;
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Source);
                return $"Имя персоны с id {person} неизвестно";
            }
        }
    }
}
