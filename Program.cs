using System;

namespace P01.UsdToBgn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // четем USD от конзолата
            double usd = double.Parse(Console.ReadLine());
            //преобразуване в лева
            double bgn = usd * 1.79549;
            //otpeqatvane na leva na konzolata
            Console.WriteLine(bgn);
        }
    }
}
