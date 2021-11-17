using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REA_Xamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        bool animationInProgress = false;
        Stopwatch stopwatch = new Stopwatch();
        public Page4()
        {
            InitializeComponent();
        }
        void OnButtonPressed(object sender, EventArgs args)
        {
            stopwatch.Start();
            animationInProgress = true;

            Device.StartTimer(TimeSpan.FromMilliseconds(16), () =>
            {
                label.Rotation = 360 * (stopwatch.Elapsed.TotalSeconds % 1);
                return animationInProgress;
            });
        }

        void OnButtonReleased(object sender, EventArgs args)
        {
            animationInProgress = false;
            stopwatch.Stop();
        }
    }
}