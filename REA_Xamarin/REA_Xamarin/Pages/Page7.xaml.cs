using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace REA_Xamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page7 : ContentPage
    {
        double FirstNum, SecondNum;
        string Operation;
        int counter = 1;
        public Page7()
        {
            InitializeComponent();
        }
        private void DigitClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;
            
            if (Result.Text == "0" || counter < 0)
            {
                Result.Text = "";
                if (counter < 0)
                {
                    counter *= -1;
                }
            }

            Result.Text += pressed;

            double num;
            if (double.TryParse(Result.Text, out num))
            {
                if (counter == 1)
                {
                    FirstNum = num;
                }
                else
                {
                    SecondNum = num;
                }
            }
        }
        private void OperatorClicked(object sender, EventArgs e)
        {
            counter = -2;
            Button button = (Button)sender;
            string pressed = button.Text;
            Operation = pressed;
        }
        private void ClearClicked(object sender, EventArgs e)
        {
            FirstNum = 0;
            SecondNum = 0;
            counter = 1;
            Result.Text = "0";
        }
        private void MinusClicked(object sender, EventArgs e)
        {
            FirstNum *= -1;
            Result.Text = (FirstNum * -1).ToString();
        }
        private void Calculate(object sender, EventArgs e)
        {
            if (counter == 2)
            {
                double result = Calculator.Calculate(FirstNum, SecondNum, Operation);
                Result.Text = result.ToString();
                FirstNum = result;
                counter = -1;
            }
        }
    }
}