using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.четем температура и част на деня
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = string.Empty;
            string shoes = string.Empty;

            // 2.проверяваме коя част от денонощието е "Morning" "Afternoon" "Evening"
            // if градусите <=18 10-18
            // else if if градусите <=24 19-24
            // else >24 24-42

            if (time == "Morning")
            {
                if (degrees <= 18) { outfit = "Sweatshirt"; shoes = "Sneakers"; }
                else if (degrees <= 24) { outfit = "Shirt"; shoes = "Moccasins"; }
                else { outfit = "T-Shirt"; shoes = "Sandals"; }

            }
            else if (time == "Afternoon")
            {
                if (degrees <= 18) { outfit = "Shirt"; shoes = "Moccasins"; }
                else if (degrees <= 24) { outfit = "T-Shirt"; shoes = "Sandals"; }
                else { outfit = "Swim Suit"; shoes = "Barefoot"; }
            }
            else 
            {
                outfit = "Shirt"; shoes = "Moccasins";
            }
            // 3. отпечатваме резултата

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
