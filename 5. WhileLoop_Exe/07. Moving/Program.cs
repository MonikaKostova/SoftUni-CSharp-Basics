using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine()); 
            int height = int.Parse(Console.ReadLine());
            int sizeRoom = width * lenght * height;

            int boxCount = 0;

            string input = Console.ReadLine();  

            while (input != "Done")
            {
                int boxes = int.Parse(input);
                boxCount += boxes;

                if (boxCount >= sizeRoom)
                {
                    Console.WriteLine($"No more free space! You need {boxCount - sizeRoom} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine(); 
            }
            
            if (boxCount < sizeRoom)
            {
                Console.WriteLine($"{sizeRoom - boxCount} Cubic meters left.");
            }
        }
    }
}
