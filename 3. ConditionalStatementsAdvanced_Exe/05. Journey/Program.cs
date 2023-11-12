using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double budgetTrip = 0.0;
            string tripType = "";
            
            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    budgetTrip = budget * 0.3;
                    tripType = "Camp";
                }
                else if (season == "winter")
                {
                    budgetTrip = budget * 0.7;
                    tripType = "Hotel";
                }
            }

            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    budgetTrip = budget * 0.4;
                    tripType = "Camp";
                }
                else if (season == "winter")
                {
                    budgetTrip = budget * 0.8;
                    tripType = "Hotel";
                }
            }

            else if (budget >1000)
            {
                destination = "Europe";
                budgetTrip = budget * 0.9;
                tripType = "Hotel";
            }

           
            Console.WriteLine($"Somewhere in {destination}");

            Console.WriteLine($"{tripType} - { budgetTrip:f2}");

        }
    }
}
