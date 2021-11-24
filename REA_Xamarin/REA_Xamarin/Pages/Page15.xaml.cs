using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REA_Xamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page15 : ContentPage
    {
        DateTime TT;

        public Page15()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
        }
        bool OnTimerTick()
        {
            if (Sw.IsToggled && DateTime.Now >= TT)
            {
                Sw.IsToggled = false;
                DisplayAlert("Timer Alert",
                "The '" + Ent.Text + "' timer has elapsed", "OK");
            }
            return true;
        }
        void OnTimePickerChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                SetTriggerTime();
            }
        }
        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            SetTriggerTime();
        }
        void SetTriggerTime()
        {
            if (Sw.IsToggled)
            {
                TT = DateTime.Today + TmPicker.Time;
                if (TT < DateTime.Now)
                {
                    TT += TimeSpan.FromDays(1);
                }
            }
        }
    }
}
