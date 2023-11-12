using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. четем от конзолата необходими пари
            //  и спестени до момента
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            // създаваме променливи за:
            // - вход от конзолата - харчи или спестява
            string input;
            // - пари, които спестява или харчи
            double money;
            // - брояч общо изминали дни
            int daysCount = 0;
            // - брояч на ПОРЕДНИ дни, в които харчи
            int spendCount = 0;


            //2. суздаваме цикъл, който да се изпълнява докато спести достатъчно
            while (availableMoney < neededMoney)
            {
                // четем действие от конзолата
                // четем сума
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());

                // увеличваме брояча с 1
                daysCount++;

                // проверяваме дали пести или харчи
                if (input == "save")
                {
                    // ако спестява дабавяме към спестявания
                    availableMoney += money;
                    // нулираме брояча на дните, в които харчи
                    spendCount = 0;
                }
                else // ако харчи
                {
                    // ако харчи увеличаваме брояча на дните, в които харчи с 1
                    spendCount++;

                    // проверяваме дали пореднитедни са повече или равни на 5
                    if (spendCount == 5) // ако са = 5 // спираме цикъла
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{daysCount}");
                        break;
                    }

                    // изваждаме сумата, които харчи от спетяванията
                    availableMoney -= money;
                    // проверяваме дали парите са станали по-малки от 0, ги правим равни на 0
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
            }
            // 3. проверяваме дали е успяла да спести пари
            if (availableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
