using System;

namespace P08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogs =int.Parse(Console.ReadLine());
            int cats =int.Parse(Console.ReadLine());    

            Console.WriteLine($"{dogs*2.50+cats*4.0} lv.");
        }
    }
}
