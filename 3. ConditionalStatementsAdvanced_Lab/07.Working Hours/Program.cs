using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayHour = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();

            if (dayHour >= 10 && dayHour <= 18 && weekDay != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
