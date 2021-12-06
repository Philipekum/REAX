using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REA_Xamarin.Pages
{
    public partial class EmbImages : ContentPage
    {
        public EmbImages()
        {
            var EmbedImage = new Image { Aspect = Aspect.Fill };
            EmbedImage.Source = ImageSource.FromResource("REA_Xamarin.MyImages.beach.jpg", typeof(EmbImages).GetTypeInfo().Assembly);
            EmbedImage.HeightRequest = 350;
            BackgroundColor = Color.Gold;
            Content = new StackLayout
            {
                Children = {new Label {Text = "Изображение как присоединенный ресурс",
                            FontSize = 40,
                            TextColor=Color.Black,
                            FontAttributes = FontAttributes.Bold,
                            HorizontalOptions = LayoutOptions.Center,
                            HorizontalTextAlignment=TextAlignment.Center
                           },
                            EmbedImage
                           },
                Margin = new Thickness(20, 50, 20, 20),
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
        }
    }
}