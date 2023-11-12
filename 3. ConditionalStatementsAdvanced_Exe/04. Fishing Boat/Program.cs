using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. четем от конзолата бюджент инт, сезон стринг и брой рибар инт
           int budget = int.Parse(Console.ReadLine());
           string season = Console.ReadLine(); 
           int fishermen = int.Parse(Console.ReadLine());

            double price = 0;
            //2. какъв е сезонът и наемът "Spring", "Summer", "Autumn", "Winter"
            //пролет 3000
            //лято или есен 4200
            //зима 2600
            switch (season) 
            {
                case "Spring": 
                    price = 3000;
                    break;
                case "Summer": 
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
             }

            //3. проверяваме отстъпката
            //<=6 10% иф
            //7-11 включително 15% иф елсе
            // повече от 12 25% елсе
            if (fishermen <= 6) { price = price - price * 0.1; }
                                     //price -= price*0.1
            else if (fishermen <= 11) { price -= price * 0.15; }
            else { price -= price * 0.25; }

            //4. проверяваме за допълнителна отстъпка 5%
            //ако рибарите са четен брой и не е есен
            if (fishermen % 2 == 0 && season != "Autumn") 
            {
                price -= price * 0.05;
            }
            //5. проверяваме дали бюджета е достатъчен
            //да - "Yes! You have {останалите пари} leva left."
            //не - "Not enough money! You need {сумата, която не достига} leva."
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! You need {price-budget:f2} leva.");
            }
        }
    }
}
