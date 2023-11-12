using System;

namespace P05._SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPacks = int.Parse(Console.ReadLine());
            int markerPacks = int.Parse(Console.ReadLine());    
            int boardLiquid = int.Parse(Console.ReadLine());    
            int discount = int.Parse(Console.ReadLine());

            double total = penPacks*5.80 + markerPacks*7.20 + boardLiquid*1.20;
            double totalWithDiscount = total - (total * discount/100);

            Console.WriteLine(totalWithDiscount);
        }
    }
}
