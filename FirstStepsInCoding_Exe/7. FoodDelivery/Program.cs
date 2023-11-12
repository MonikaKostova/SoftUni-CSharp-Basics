using System;

namespace P07._FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());   
            int veggieMenu = int.Parse(Console.ReadLine());

            double totalChickenMenu = chickenMenu * 10.35;
            double totalFishMenu = fishMenu * 12.40;
            double totalVeggieMenu = veggieMenu * 8.15;

            double sumOrder = totalChickenMenu + totalFishMenu + totalVeggieMenu;
            double sumDessert = sumOrder * 0.20;
            double delivery = 2.50;

            double totalSumOrder = sumOrder + sumDessert + delivery;

            Console.WriteLine(totalSumOrder);

        }
    }
}
