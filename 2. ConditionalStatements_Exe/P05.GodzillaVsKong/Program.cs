using System;

namespace P05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double availableBudget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double costumes = double.Parse(Console.ReadLine());

            double decor = availableBudget * 0.10;
            double moneyForCostumes;
            double neededBudget;

            if (actors > 150)
            {
                costumes = costumes - (costumes * 0.10);
                moneyForCostumes = costumes * actors;
            }
            else
            {
                moneyForCostumes = costumes * actors;
            }
            neededBudget = moneyForCostumes + decor;

            if (neededBudget > availableBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(neededBudget - availableBudget):F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(neededBudget - availableBudget):F2} leva left.");
            }
        }
    }
}
