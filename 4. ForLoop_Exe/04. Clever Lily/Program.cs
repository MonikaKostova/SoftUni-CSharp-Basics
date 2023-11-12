using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWash = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int money = 0; //спестявания
           
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) //четен, пари
                {
                    money += i * 5 - 1;
                }
                else //нечетен, играчка
                {
                    money += priceToy;
                }
            }
            if (money >= priceWash)
            {
                Console.WriteLine($"Yes! {money-priceWash:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWash-money:f2}");
            }
        }
    }
}
