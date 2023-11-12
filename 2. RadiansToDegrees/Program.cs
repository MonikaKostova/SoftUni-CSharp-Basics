using System;

namespace P02._RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // четем radiani от конзолата
            double radians = double.Parse(Console.ReadLine());
            //преобразуване в gradusi градус = радиан * 180 / π
            double degrees = radians * 180 / Math.PI;
            //otpeqatvane na gradusite na konzolata
            Console.WriteLine(degrees); 
        }
    }
}
