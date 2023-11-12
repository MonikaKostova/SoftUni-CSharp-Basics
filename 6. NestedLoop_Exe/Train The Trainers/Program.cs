using System;
using System.Transactions;

namespace Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJury = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            string presentationName;
            int presentationCount = 0;
            double averageGrade = 0;
            double averageGradeCount = 0; //sumata na vsi4ki sredni ocenki

            while (input != "Finish") 
            {
                presentationName = input;
                averageGrade = 0;

                for (int i =1; i <= numJury; i++)
                {
                    averageGrade += double.Parse(Console.ReadLine());
                }
                averageGrade = averageGrade / numJury;
                Console.WriteLine($"{presentationName} - {averageGrade:f2}.");

                averageGradeCount+= averageGrade;
                presentationCount++;

                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {averageGradeCount / presentationCount:f2}.");

        }
    }
}
