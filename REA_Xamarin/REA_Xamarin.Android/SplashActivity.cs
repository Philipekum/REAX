using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support;

namespace REA_Xamarin.Droid
{
    [Activity(Icon = "@mipmap/RX_icon", Label = "REAX", Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(0);
            StartActivity(typeof(MainActivity));

        }
        
        async Task SimulateStartup()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        protected override async void OnResume()
        {
            base.OnResume();
            await SimulateStartup();
        }
    }
}