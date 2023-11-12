using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // монети от 2лв(200), 1лв (100), 50ст, 20ст, 10 ст, 5ст, 2ст, 1ст

            // 1. четем от конзолата какво ресто трябва да върнем
            // и го превръщаме в стотинки
            double changeToReturn = double.Parse(Console.ReadLine())*100;


            // създаваме брояч на монетите, които връщаме
            int count = 0;

            // 2. създаваме цикъл, който да се изпълнява докато не върнем цялото ресто
            // при цялото изпълнение ще връщаме най-голямата възможна монета
            // изваждаме стойността й от рестото
            // увеличаваме брояча на монети с 1
            while (changeToReturn > 0)
            {
                if (changeToReturn >= 200)
                {
                    changeToReturn -= 200;
                }
                else if (changeToReturn >= 100)
                {
                    changeToReturn -= 100;
                }
                else if (changeToReturn >= 50)
                {
                    changeToReturn -= 50;
                }
                else if (changeToReturn >= 20)
                {
                    changeToReturn -= 20;
                }
                else if (changeToReturn >= 10)
                {
                    changeToReturn -= 10;
                }
                else if (changeToReturn >= 5)
                {
                    changeToReturn -= 5;
                }
                else if (changeToReturn >= 2)
                {
                    changeToReturn -= 2;
                }
                else if (changeToReturn >= 1)
                {
                    changeToReturn -= 1;
                }
                else
                {
                    changeToReturn = 0;
                    break;
                }

                count++;
            }

            // 3. отпечатваме броя монети, които сме върнали

            Console.WriteLine(count);
        }
    }
}
