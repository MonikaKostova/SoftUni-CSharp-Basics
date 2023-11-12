using System;

namespace P08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());
            
            double sneakers = annualFee - (annualFee*0.40);
            double outfit = sneakers - (sneakers * 0.20);
            double ball = outfit / 4;
            double accessories = ball / 5;

            double totalExpence = annualFee + sneakers + outfit + ball + accessories;

            Console.WriteLine(totalExpence);
        }
    }
}
