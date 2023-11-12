using System;

namespace P09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine()); 
            double accessories = double.Parse(Console.ReadLine()); 

            double fishTank = a*b*h;
            //obem v sm3
            double tankCapacityLiters = fishTank * 0.001;
            //obem v litri

            double filledSpace = tankCapacityLiters * accessories / 100;

            double emptySpace = tankCapacityLiters - filledSpace;

            Console.WriteLine(emptySpace);


           
        }
    }
}
