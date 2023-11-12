using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.създаваме променливи за броя стъпки  и за входа от конзолата
            int steps = 0;
            string input;

            //2.създавама цикъл до постигане на целта
            while (steps < 10000)
            {
                // четем вход от конзолата
                input = Console.ReadLine();
                // проверяваме дали входът е стъпки или "Going home"
                if (input == "Going home") // ako e "Going home"
                {
                    // четем стъпки, които изминава до вкъщи и ги добавяме към общия брой
                    steps += int.Parse(Console.ReadLine());

                    // спираме цикъла
                    break;
                }
                // ако не е  == преобразуваме входът в число и добавяме стъпките към общия брой
                steps += int.Parse(input);
            }

            //3. проверяваме дали е постигнала целта си
            if (steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - 10000} steps over the goal!");
            }
            else //ако не е
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
        }

    }
}
