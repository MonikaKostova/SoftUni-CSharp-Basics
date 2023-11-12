using System;
using System.Drawing;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4etem ot konzolata n = broq na 4islata, koito da o4akvame
            int n = int.Parse(Console.ReadLine());

            double p1 = 0; // pazim samo BROQ 4isla
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            int number;

            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++; //увеличаване на броя на числата в конкретния диапазон
                }
                else if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }

            }
            Console.WriteLine($"{(p1 / n * 100):F2}%");
            Console.WriteLine($"{(p2 / n * 100):F2}%");
            Console.WriteLine($"{(p3 / n * 100):F2}%");
            Console.WriteLine($"{(p4 / n * 100):F2}%");
            Console.WriteLine($"{(p5 / n * 100):F2}%");
        }
    }
}
