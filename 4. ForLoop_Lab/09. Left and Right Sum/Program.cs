using System;
using System.Security.Cryptography;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int topSum = 0;
            for (int i=1; i<=n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                topSum += currentNumber;
            }

            int bottomSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                bottomSum += currentNumber;
            }
            if (topSum == bottomSum)
            {
                Console.WriteLine("Yes, sum = " + topSum);
            }
            else
            {
                int diff = Math.Abs(bottomSum - topSum);
                Console.WriteLine("No, diff = " + diff);
            }

        }
    }
}
