using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            
            double priceStudio = 0.0;
            double priceApartment = 0.0;


            if (month == "May" || month == "October")
            {

                priceStudio = 50 * nights;
                priceApartment = 65 * nights;

                if (nights > 7 && nights < 14)
                {
                    priceStudio -= priceStudio * 0.05;
                }

                else if (nights > 14)
                {
                    priceStudio -= priceStudio * 0.30;
                    priceApartment -= priceApartment * 0.10;
                }
            }

            else if (month == "June" || month == "September")
            {
                priceStudio = 75.20 * nights;
                priceApartment = 68.70 * nights;


                if (nights > 14)
                {
                    priceStudio -= priceStudio * 0.20;
                    priceApartment -= priceApartment * 0.10;
                }
            }

            else if (month == "July" || month == "August")
            {
                priceStudio = 76 * nights;
                priceApartment = 77 * nights;

                if (nights > 14)
                {
                    priceApartment -= priceApartment * 0.1;
                }

            }
                Console.WriteLine($"Apartment: {priceApartment:f2} lv.");

                Console.WriteLine($"Studio: {priceStudio:f2} lv.");

            
        }
    }
}


