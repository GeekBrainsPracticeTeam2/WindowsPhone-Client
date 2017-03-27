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

        public List<DailyStatistics> EveryDayStats { get; set; }
        public List<TotalStatis> GeneralStatistis { get; set; }
        public List<Site> Sites { get; set; }
        public List<Person> Persons { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            using(DBDictionary db = new DBDictionary())
            {
                //Site site1 = new Site(1, "lenta.ru");
                //Site site2 = new Site(2, "rio.ru");

                //Person person1 = new Person(1, "Вова");
                //Person person2 = new Person(2, "Петя");

                //db.Persons.Add(person1);
                //db.Persons.Add(person2);
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
            EveryDayStats = new List<DailyStatistics>()
            {
                new DailyStatistics{
                    siteId = 0,
                    statistics = new List<stat>()
                    {
                        new stat
                        {
                            date = DateTime.Now,
                            personsStats = new List<PersonStats>()
                            {
                                new PersonStats
                                {
                                    person = 1,
                                    count = 1
                                },
                                new PersonStats
                                {
                                    person = 2,
                                    count = 2
                                },
                                new PersonStats
                                {
                                    person = 3,
                                    count = 3
                                }
                            }
                        },
                        new stat
                        {
                            date = DateTime.Now,
                            personsStats = new List<PersonStats>()
                            {
                                new PersonStats
                                {
                                    person = 1,
                                    count = 2
                                },
                                new PersonStats
                                {
                                    person = 2,
                                    count = 3
                                },
                                new PersonStats
                                {
                                    person = 3,
                                    count = 4
                                }
                            }
                        },
                        new stat
                        {
                            date = DateTime.Now,
                            personsStats = new List<PersonStats>()
                            {
                                new PersonStats
                                {
                                    person = 1,
                                    count = 3
                                },
                                new PersonStats
                                {
                                    person = 2,
                                    count = 4
                                },
                                new PersonStats
                                {
                                    person = 3,
                                    count = 5
                                }
                            }
                        }
                    },
                },
                new DailyStatistics{
                    siteId = 1,
                    statistics = new List<stat>()
                    {
                        new stat
                        {
                            date = DateTime.Now,
                            personsStats = new List<PersonStats>()
                            {
                                new PersonStats
                                {
                                    person = 1,
                                    count = 1
                                },
                                new PersonStats
                                {
                                    person = 2,
                                    count = 2
                                },
                                new PersonStats
                                {
                                    person = 3,
                                    count = 3
                                }
                            }
                        },
                        new stat
                        {
                            date = DateTime.Now,
                            personsStats = new List<PersonStats>()
                            {
                                new PersonStats
                                {
                                    person = 1,
                                    count = 2
                                },
                                new PersonStats
                                {
                                    person = 2,
                                    count = 3
                                },
                                new PersonStats
                                {
                                    person = 3,
                                    count = 4
                                }
                            }
                        },
                        new stat
                        {
                            date = DateTime.Now,
                            personsStats = new List<PersonStats>()
                            {
                                new PersonStats()
                                {
                                    person = 1,
                                    count = 3
                                },
                                new PersonStats()
                                {
                                    person = 2,
                                    count = 4
                                },
                                new PersonStats()
                                {
                                    person = 3,
                                    count = 5
                                }
                            }
                        }
                    }
                }
            };


        }

        private void EverydayGridView_Loaded(object sender, RoutedEventArgs e)
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

        private void GeneralStaticGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var gridView = (GridView)sender;
            gridView.ItemsSource = GeneralStatistis;
        }
    }
}
