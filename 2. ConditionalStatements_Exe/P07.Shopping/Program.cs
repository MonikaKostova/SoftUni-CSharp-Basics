using System;

namespace P07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine()); 
            int p = int .Parse(Console.ReadLine());

            double videoCards = n * 250;

            double processors = m * (videoCards * 0.35);

            double ramMemory = p * (videoCards * 0.10);

            double totalExpense = videoCards + ramMemory + processors;

           
            if (videoCards > processors) 
            {
                totalExpense = totalExpense*0.85;
            }

            if (totalExpense <= budget)
            {
                Console.WriteLine($"You have {budget-totalExpense:f2} leva left!");
            }
            else 
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(totalExpense - budget):f2} leva more!");
            }

        }
    }
}
