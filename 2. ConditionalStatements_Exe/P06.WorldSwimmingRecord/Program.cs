using System;

namespace P06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double delay = Math.Floor(distance / 15) * 12.5;
            double recordIvan = distance * timePerMeter + delay;

            if (recordIvan < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordIvan:f2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(worldRecord - recordIvan):f2} seconds slower.");
            }

        }
    }
}
