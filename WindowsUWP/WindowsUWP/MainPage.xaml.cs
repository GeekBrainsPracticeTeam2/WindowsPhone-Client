using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WindowsUWP.models;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace WindowsUWP
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public List<PersonStats> EveryDayStats { get; set; }
        public List<Site> Sites { get; set; }
        public List<Person> Persons { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            EveryDayStats = new List<models.PersonStats>
            {
                new models.PersonStats(DateTime.Now, 2000),
                new models.PersonStats(DateTime.Now, 3000),
                new models.PersonStats(DateTime.Now, 2050),
                new models.PersonStats(DateTime.Now, 200),
            };

            using(DBDictionary db = new DBDictionary())
            {
                //Site site1 = new Site(1, "lenta.ru");
                //Site site2 = new Site(2, "rio.ru");

                //db.Sites.Add(site1);
                //db.Sites.Add(site2);
                //db.SaveChanges();

                var sites = from p in db.Sites
                            select p;

                var persons = from p in db.Persons
                             select p;

                Persons = persons.ToList();
                Sites = sites.ToList();         
            }
        }



        private void Page_Loading(FrameworkElement sender, object args)
        {
            TotalStatis site = new TotalStatis(0,0);
        }

        private void GridView_Loaded(object sender, RoutedEventArgs e)
        {
            var gridView = (GridView)sender;
            gridView.ItemsSource = EveryDayStats;
        }

        private void ComboBoxSites_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = (ComboBox)sender;
            comboBox.ItemsSource = Sites;
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = (ComboBox)sender;
            comboBox.ItemsSource = Persons;
        }
    }
}
