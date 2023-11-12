using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            double flowerPrice = 0;

            switch (flowerType) 
            {
                case "Roses": 
                    flowerPrice = 5;

                    if (flowerCount > 80) 
                    {
                        totalPrice = (flowerPrice * flowerCount);
                        totalPrice -= totalPrice * 0.10;
                    }
                    else
                    {
                        totalPrice = flowerPrice* flowerCount;
                    }

                    break;

                case "Dahlias":
                    flowerPrice = 3.80;

                    if (flowerCount > 90)
                    {
                        totalPrice = (flowerPrice * flowerCount);
                        totalPrice -= totalPrice * 0.15;
                    }
                    else
                    {
                        totalPrice = flowerPrice * flowerCount;
                    }

                    break;
                case "Tulips":
                    flowerPrice = 2.80;

                    if (flowerCount > 80)
                    {
                        totalPrice = (flowerPrice * flowerCount);
                        totalPrice -= totalPrice * 0.15;
                    }
                    else
                    {
                        totalPrice = flowerPrice * flowerCount;
                    }

                    break;
                case "Narcissus":
                    flowerPrice = 3;

                    if (flowerCount <120)
                    {
                        totalPrice = (flowerPrice * flowerCount);
                        totalPrice += totalPrice * 0.15;
                    }
                    else
                    {
                        totalPrice = flowerPrice * flowerCount;
                    }

                    break;
                case"Gladiolus":
                    flowerPrice = 2.50;

                    if (flowerCount < 80)
                    {
                        totalPrice = (flowerPrice * flowerCount);
                        totalPrice += totalPrice * 0.20;
                    }
                    else
                    {
                        totalPrice = flowerPrice * flowerCount;
                    }

                    break;

            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {(budget - totalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalPrice - budget):f2} leva more.");
            }


        }
    }
}
