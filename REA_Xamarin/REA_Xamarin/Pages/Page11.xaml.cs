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
    public partial class Page11 : HeaderFooterPage
    {
        Label TemLabel;
        public Page11()
        {
            InitializeComponent();
        }
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            TemLabel = (Label)GetTemplateChild("СhangeThemeLabel");
            TemLabel.Text = OriginalTemplate ? "Orange Theme" : "Green Theme";
        }
    }
}