using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsUWP.models
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Person() { }

        public Person(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}
