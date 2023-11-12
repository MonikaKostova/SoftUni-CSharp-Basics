using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a,3:F3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b,3:F3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(Math.Pow(r, 2) * Math.PI),3:F3}");
            }
            else if (figure == "triangle")
            { 
                double a = double.Parse((Console.ReadLine()));
                double h = double.Parse((Console.ReadLine()));
                Console.WriteLine($"{(a * h) / 2, 3:F3}");
            }
        }
    }
}
