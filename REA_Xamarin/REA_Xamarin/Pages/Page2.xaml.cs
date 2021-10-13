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
            Label header = new Label
            {
                Text = "Про пацанов, которых воспитала улица: ",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
            Label header1 = new Label
            {
                Text = "Миша Будуев",
                FontSize = 20,
                FontAttributes = FontAttributes.Italic,
            };

            Label label1 = new Label
            {
                Text = "Он не ест гречневую кашу " + "Любит он старосту Машу " + "Глазками стреляет очень метко " + "Вот тебе контрольный, детка!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            Label header2 = new Label
            {
                Text = "Паша Долманский",
                FontSize = 20,
                FontAttributes = FontAttributes.Italic,
            };
            Label label2 = new Label
            {
                Text = "Шаболовская, зима, газировка " + "Старые коньки, хоккей, дворовая коробка. " + "Мальчик Паша в шарфе клетчатом " + "Гоняет шайбу с ребетней с утра до вечера.",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            Label header3 = new Label
            {
                Text = "Серега Королев",
                FontSize = 20,
                FontAttributes = FontAttributes.Italic,
            };

            Label label3 = new Label
            {
                Text = "Знают все девчонки в мире,\nЧто Серега хулиган " + "Белый мерин, белый мерин " + "Мой надежный, верный конь",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            Label header4 = new Label
            {
                Text = "Phil Цеханский",
                FontSize = 20,
                FontAttributes = FontAttributes.Italic,
            };

            Label label4 = new Label
            {
                Text = "Филипп, мужик, я поздравляю " + "Девчонок кучу и любви желаю " + "И счастье пусть не за горами, " + "Враги уже все под ногами.",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            Title = "Дворовая шпана";
            Padding = new Thickness(10, 0);
            Content = new StackLayout
            { Children = { header, header1, label1, header2, label2, header3, label3, header4, label4 } };
        }
    }
};