using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int grade = 1;
            int classFail = 0;
            double marksSum = 0;

           while (grade <= 12)
           {
                double currentGradeMark = double.Parse(Console.ReadLine());

                if (currentGradeMark < 4)
                { 
                    classFail++;

                    if(classFail > 1)
                    {
                        break;
                    }
                    continue;
                }
                marksSum += currentGradeMark;
                grade++;
           }
            if (classFail > 1)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                double averageMark = marksSum / (grade - 1);
                Console.WriteLine($"{name} graduated. Average grade: {averageMark:f2}");
            }
        }
    }
}
