using System;
using WindowsUWP.Helpers;

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
                    PersonName = DBhelper.GetNamePerson(this.person);
                    return PersonName;
                }
                return PersonName;
            }

            protected set
            {

            }
        }
    }
}
