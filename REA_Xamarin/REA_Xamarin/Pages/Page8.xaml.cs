using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Core;

namespace REA_Xamarin.Pages
{
    public partial class Page8 : FlyoutPage
    {
        public MasterBehavior MasterBehavior { get; set; }
        public Page8()
        {
            Label header = new Label
            {
                Text = "FlyoutPage",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            NamedColorPages[] namedColors =
            {
                new NamedColorPages ("Aqua", Color.Aqua),
                new NamedColorPages ("Black", Color.Black),
                new NamedColorPages ("Blue", Color.Blue),
                new NamedColorPages ("Fuchsia", Color.Fuchsia),
                new NamedColorPages ("Gray", Color.Gray),
                new NamedColorPages ("Green", Color.Green),
                new NamedColorPages ("Lime", Color.Lime),
                new NamedColorPages ("Maroon", Color.Maroon),
                new NamedColorPages ("Navy", Color.Navy),
                new NamedColorPages ("Olive", Color.Olive),
                new NamedColorPages ("Purple", Color.Purple),
                new NamedColorPages ("Red", Color.Red),
                new NamedColorPages ("Silver", Color.Silver),
                new NamedColorPages ("Teal", Color.Teal),
                new NamedColorPages ("White", Color.White),
                new NamedColorPages ("Yellow", Color.Yellow)
            };

            ListView listView = new ListView
            {
                ItemsSource = namedColors,
                Margin = new Thickness(10, 0),
                BackgroundColor = Color.Black
            };

            Flyout = new ContentPage
            {
                Title = "Color List",
                Content = new StackLayout
                {
                    Children =
                    {
                        header, listView
                    }
                }
            };

            Classes.NamedColorPages2 detailPage = new Classes.NamedColorPages2();
            Detail = detailPage;

            listView.ItemSelected += (sender, args) =>
            {
                Detail.BindingContext = args.SelectedItem;
                IsPresented = true;
            };

            listView.SelectedItem = namedColors[5];
            MasterBehavior = MasterBehavior.Popover;
        }
    }
}