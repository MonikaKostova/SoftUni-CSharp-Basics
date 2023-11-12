using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); 
            string roomType = Console.ReadLine(); 
            string evaluation = Console.ReadLine();

            double roomPrice = 0;
            int nights = days - 1;
            
            if(roomType == "room for one person")
            {
                roomPrice = 18*nights;
            }
            else if (roomType == "apartment")
            {
                roomPrice = 25*nights;

                if (days < 10)
                {
                    roomPrice -= roomPrice * 0.30;
                }
                else if (days >= 10 && days <= 15)
                {
                    roomPrice -= roomPrice * 0.35;
                }
                else if (days > 15)
                {
                    roomPrice -= roomPrice * 0.50;
                }
            }
            else if (roomType == "president apartment")
            {
                roomPrice = 35*nights;
                if (days < 10)
                {
                    roomPrice -= roomPrice * 0.10;
                }
                else if (days >= 10 && days <= 15)
                {
                    roomPrice -= roomPrice * 0.15;
                }
                else if (days > 15)
                {
                    roomPrice -= roomPrice * 0.20;
                }
            }
            switch (evaluation)
            {
                case "positive":
                    roomPrice += roomPrice * 0.25;
                    break;
                case "negative":
                    roomPrice -= roomPrice * 0.10;
                    break;
            }
            Console.WriteLine($"{roomPrice:f2}");

        }
    }
}
