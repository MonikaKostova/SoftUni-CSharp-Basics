using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsNum = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            double winPoints = 0;
            double winnerCount = 0;
            string tournamentStage = "";
            double totalPoints = 0;
            double percentageWins = 0;


            for (int i = 1; i <= tournamentsNum; i++)
            {
                tournamentStage = Console.ReadLine();

                if (tournamentStage == "W")
                {
                    winPoints += 2000;
                    winnerCount++;
                }
                else if (tournamentStage == "F")
                {
                    winPoints+= 1200;
                }
                else if (tournamentStage == "SF")
                {
                    winPoints += 720;
                }
                
            }
            totalPoints = startPoints + winPoints;
            percentageWins = winnerCount / tournamentsNum * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(winPoints / tournamentsNum)}");
            Console.WriteLine($"{percentageWins:f2}%");
        }
    }
}
