namespace WindowsUWP.models
{
    public class Site
    {
        public int ID { get; set; }
        public string Url { get; set; }

        public Site() { }

        public Site(int id, string Url)
        {
            ID = id;
            this.Url = Url;
        }
    }
}
