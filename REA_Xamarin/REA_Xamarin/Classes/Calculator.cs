using System;
using System.Collections.Generic;
using System.Text;

namespace REA_Xamarin
{
    class Calculator
    {
        public static double Calculate(double FirstNum, double SecondNum, string Operation)
        {
            double res = 0;

            switch (Operation)
            {
                case "+":
                    res = FirstNum + SecondNum;
                    break;

                case "-":
                    res = FirstNum - SecondNum;
                    break;

                case "X":
                    res = FirstNum * SecondNum;
                    break;

                case "DIV":
                    res = FirstNum / SecondNum;
                    break;             
            }

            return res;
        }      
    }
}
