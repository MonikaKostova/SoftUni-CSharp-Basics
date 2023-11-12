﻿using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string city = Console.ReadLine();
           double sales = double.Parse(Console.ReadLine());
           double commission = 0.0;
           bool error = false;

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500) { commission = 0.05; }
                else if (sales > 500 && sales <= 1000) { commission = 0.07; }
                else if (sales > 1000 && sales <= 10000) { commission = 0.08; }
                else if (sales > 10000) { commission = 0.12; }
                else { Console.WriteLine("error"); error = true;}
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500) { commission = 0.045; }
                else if (sales > 500 && sales <= 1000) { commission = 0.075; }
                else if (sales > 1000 && sales <= 10000) { commission = 0.10; }
                else if (sales > 10000) { commission = 0.13; }
                else { Console.WriteLine("error"); error = true; }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500) { commission = 0.055; }
                else if (sales > 500 && sales <= 1000) { commission = 0.08; }
                else if (sales > 1000 && sales <= 10000) { commission = 0.12; }
                else if (sales > 10000) { commission = 0.145; }
                else { Console.WriteLine("error"); error = true; }
            }
            else { Console.WriteLine("error"); error = true; }

            if (error == false) { Console.WriteLine($"{sales*commission:F2}"); }
        }
    }
}
