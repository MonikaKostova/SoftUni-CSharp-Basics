using System;

namespace P06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon =int.Parse(Console.ReadLine());
            int paint =int.Parse(Console.ReadLine());   
            int thinner =int.Parse(Console.ReadLine()); 
            int hours =int.Parse(Console.ReadLine());

            double totalNylon = (nylon + 2) * 1.5;
            double totalPaint = (paint + paint*0.10) * 14.50;
            double totalThinner = thinner * 5;
            double bags = 0.40;
            
            double totalMaterials = totalNylon + totalPaint + totalThinner + bags;
            double workExpense = (totalMaterials * 0.3)*hours;
            double totalAmount = totalMaterials + workExpense;

            Console.WriteLine(totalAmount);


        }
    }
}
