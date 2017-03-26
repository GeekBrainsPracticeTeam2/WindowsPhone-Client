namespace WindowsUWP.models
{
    public class Person
    {
        public int ID { get; set; }
        public string name { get; set; }

        public Person() { }

        public Person(int ID, string Name)
        {
            this.ID = ID;
            this.name = Name;
        }
    }
}
