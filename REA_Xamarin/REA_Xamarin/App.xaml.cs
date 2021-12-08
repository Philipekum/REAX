﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REA_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "Expander_Experimental" });
            MainPage = new NavigationPage(new REA_Xamarin.MainPage());

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
