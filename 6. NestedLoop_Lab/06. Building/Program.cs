using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsTotal = int.Parse(Console.ReadLine());
            int appTotal = int.Parse(Console.ReadLine()); 

            for (int currentFloor = floorsTotal; currentFloor >= 1; currentFloor--)
            {
                char letter = 'z';
                if (currentFloor == floorsTotal)
                {
                    letter = 'L';
                }
                else if (currentFloor % 2 == 0)
                {
                    letter = 'O';
                }
                else if (currentFloor % 2 != 0)
                {
                    letter = 'A';
                }
                for (int currentApp = 0; currentApp < appTotal; currentApp++)
                {
                    Console.Write($"{letter}{ currentFloor}{currentApp} ");
                }
                Console.WriteLine();
            }
        }
    }
}
