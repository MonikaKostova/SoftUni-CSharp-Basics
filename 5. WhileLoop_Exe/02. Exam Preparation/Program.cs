using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. четем от конзолата
            // брой на незадоволителните оценки, които може да получи
            int filedTimes = int.Parse(Console.ReadLine());

            // 2.създаваме променливи
            // сумата на всички оценки
            int evaluationSum = 0;
            // брояч на всички оценки
            int evaluationCount = 0;
            // брояч на незадоволителни оценки
            int filedCount = 0;
            // имe на последната задача
            string lastExercise = string.Empty;

            string input = Console.ReadLine();
            int evaluation;

            // 3. създаваме while цикъл до enough
            while (input != "Enough")
            {  
                // ако input != enough >>той е име на последната дадена задача
                lastExercise= input;
                // четем оценка за конкретната задача
                evaluation = int.Parse(Console.ReadLine());

                // добавяме оценката към сумата на всички
                evaluationSum += evaluation;

                // увеличаваме брояча с 1
                evaluationCount++;

                // проверяваме оценката дали е  незадоволителна
                if (evaluation <= 4)
                {
                // ако не е увеличаваме брояча с 1
                    filedCount ++;

                    // проверяваме далие  достигнат броят на незадоволителните оценки
                    if (filedCount == filedTimes) 
                    {
                        Console.WriteLine($"You need a break, {filedCount} poor grades.");
                        // ако е спираме цикъла
                        break;
                    }
                }
                // четем нов вход от конзолата
                input = Console.ReadLine(); 
            }

            // 4. проверяваме дали последния Input от конзолата  е == enough
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {(double)evaluationSum/evaluationCount:f2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
        }
    }
}
