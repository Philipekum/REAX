using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using REA_Xamarin.Pages;

namespace REA_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Page1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        private async void Button_Page2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void Button_Page3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
        private async void Button_Page4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
        private async void Button_Page5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
        private async void Button_Page6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page6());
        }
        private async void Button_Page7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page7());
        }
        private async void Button_Page8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page8());
        }
        private async void Button_Page9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page9());
        }
        private async void Button_Page10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page10());
        }
        private async void Button_Page11(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page11());
        }
        private async void Button_Page12(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page12());
        }
        private async void Button_Page13(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page13());
        }
        private async void Button_Page14(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page14());
        }
        private async void Button_Page15(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page15());
        }
    }
}
