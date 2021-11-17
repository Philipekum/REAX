using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REA_Xamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            Grid grid = new Grid
            {
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions =
                {
                    new RowDefinition(),
                    new RowDefinition(),
                    new RowDefinition()
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                    new ColumnDefinition()
                }
            };

            //Row 0
            grid.Children.Add(new BoxView
            {
                Color = Color.AliceBlue
            });

            grid.Children.Add(new Label
            {
                Text = "Upper left",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start
            }); ;



            grid.Children.Add(new BoxView
            {
                Color = Color.LightSkyBlue
            }, 1, 0);

            grid.Children.Add(new Label
            {
                Text = "Upper center",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            }, 1, 0);



            grid.Children.Add(new BoxView
            {
                Color = Color.CadetBlue
            }, 2, 0);

            grid.Children.Add(new Label
            {
                Text = "Upper right",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Start
            }, 2, 0);



            // Row 1
            grid.Children.Add(new BoxView
            {
                Color = Color.CornflowerBlue
            }, 0, 1);

            grid.Children.Add(new Label
            {
                Text = "Center left",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            }, 0, 1);



            grid.Children.Add(new BoxView
            {
                Color = Color.DodgerBlue
            }, 1, 1);

            grid.Children.Add(new Label
            {
                Text = "Center",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }, 1, 1);



            grid.Children.Add(new BoxView
            {
                Color = Color.DarkSlateBlue
            }, 2, 1);

            grid.Children.Add(new Label
            {
                Text = "Center right",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center
            }, 2, 1);



            // Row 2
            grid.Children.Add(new BoxView
            {
                Color = Color.SteelBlue
            }, 0, 2);

            grid.Children.Add(new Label
            {
                Text = "Lower left",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.End
            }, 0, 2);



            grid.Children.Add(new BoxView
            {
                Color = Color.LightBlue
            }, 1, 2);

            grid.Children.Add(new Label
            {
                Text = "Lower center",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            }, 1, 2);



            grid.Children.Add(new BoxView
            {
                Color = Color.BlueViolet
            }, 2, 2);

            grid.Children.Add(new Label
            {
                Text = "Lower right",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End
            }, 2, 2);



            Title = "Grid alignment demo";
            Content = grid;
        }
    }
}