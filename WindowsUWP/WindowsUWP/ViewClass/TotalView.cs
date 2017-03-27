using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsUWP.Helpers;

namespace WindowsUWP.ViewClass
{
    class TotalView
    {
        int personId;
        public string personName { get; protected set; }
        public int rank { get; protected set; }

        public TotalView(int personId, int rank)
        {
            this.rank = rank;
            this.personId = personId;
            personName = DBhelper.GetNamePerson(personId);
        }
    }
}
