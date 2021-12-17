using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REA_Xamarin
{
    public partial class App : Application
    {
        static Classes.TodoItemDatabase database;

        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "Expander_Experimental" });
            MainPage = new NavigationPage(new MainPage());

        }
        public static Classes.TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new Classes.TodoItemDatabase();
                }
                return database;
            }
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
