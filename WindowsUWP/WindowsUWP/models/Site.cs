namespace WindowsUWP.models
{
    public class Site
    {
        public int ID { get; set; }
        public string name { get; set; }

        public Site() { }

        public Site(int id, string Url)
        {
            ID = id;
            this.name = Url;
        }
    }
}
