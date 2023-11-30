using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTLISTEmobile
{
    public partial class App : Application
    {
        static ContactsDatabase database;
        public static ContactsDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ContactsDatabase(Path.Combine(Environment.GetFolderPath((Environment.SpecialFolder.LocalApplicationData)), "contact.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
