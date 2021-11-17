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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            BackgroundColor = Color.Black;
            Title = "Content Page";
            Padding = new Thickness(10, 0);

            Content = new StackLayout
            { 
                Children = 
                {
                    new Label
                    {
                        Text = "Про пацанов, которых воспитала улица: \n",
                        TextColor = Color.White,
                        FontSize = 25,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "Миша Будуев",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Italic,
                        TextColor = Color.White

                    },
                    new Label
                    {
                        TextColor = Color.White,
                        Text = "Он не ест гречневую кашу\nЛюбит он старосту Машу\nГлазками стреляет очень метко\nВот тебе контрольный, детка!\n",
                        FontSize = 18
                    },
                    new Label
                    {
                        Text = "Паша Долманский",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Italic,
                        TextColor = Color.White,

                    },
                    new Label
                    {
                        Text = "Шаболовская, зима, газировка\nСтарые коньки, хоккей, дворовая коробка.\nМальчик Паша в шарфе клетчатом\nГоняет шайбу с ребетней с утра до вечера.\n",
                        FontSize = 18,
                        TextColor = Color.White,

                    },
                    new Label
                    {
                        Text = "Серега Королев",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Italic,
                        TextColor = Color.White,

                    },
                    new Label
                    {
                        Text = "Знают все девчонки в мире,\nЧто Серега хулиган\nБелый мерин, белый мерин\nМой надежный, верный конь\n",
                        FontSize = 18,
                        TextColor = Color.White,

                    },
                    new Label
                    {
                        Text = "Phil Цеханский",
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes = FontAttributes.Italic,
                        TextColor = Color.White,

                    },
                    new Label
                    {
                        Text = "Филипп, мужик, я поздравляю\nДевчонок кучу и любви желаю\nИ счастье пусть не за горами,\nВраги уже все под ногами.\n",
                        FontSize = 18,
                        TextColor = Color.White,

                    }
                } 
            };
        }
    }
};