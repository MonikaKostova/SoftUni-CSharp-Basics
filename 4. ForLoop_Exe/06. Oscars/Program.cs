using System;
using System.Runtime.ConstrainedExecution;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double startPoints = double.Parse(Console.ReadLine());
            int judgeNumber = int.Parse(Console.ReadLine());
                                 
                        
            for (int i = 1; i <= judgeNumber; i++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());

                startPoints += judgeName.Length * judgePoints / 2.0;

                if (startPoints > 1250.5)
                {
                    break;
                }
            }

            if (startPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {startPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - startPoints):f1} more!");
            }
        }
    }
}
