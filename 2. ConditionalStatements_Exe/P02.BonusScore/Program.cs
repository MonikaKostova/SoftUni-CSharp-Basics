﻿using System;

namespace P02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus;

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number <= 1000)
            {
                bonus = number * 0.20;
            }
            else
            {
                bonus = number * 0.10;
            }

            if (number % 2 == 0)
            {
                bonus = bonus + 1;
            }
            if (number % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);

        }
    }
}
