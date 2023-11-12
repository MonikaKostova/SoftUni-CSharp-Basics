using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeA = int.Parse(Console.ReadLine());
            int cakeB = int.Parse(Console.ReadLine());
            int cakePieces = cakeA * cakeB;

            int countPieces = 0;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int guests = int.Parse(input);
                countPieces += guests;

                if (cakePieces <= countPieces)
                {
                    Console.WriteLine($"No more cake left! You need {countPieces - cakePieces} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }

            if (cakePieces > countPieces)
            {
                Console.WriteLine($"{cakePieces - countPieces} pieces are left.");

            }
                
        }
    }
}
