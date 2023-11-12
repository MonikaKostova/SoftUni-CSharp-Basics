using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четем начало и край
            //четем магическо число
            //създаваме променливи, която да пази броя на всички комбинации, които сме опитали докато търсим вярната
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combination = 0;
            bool flag = false;

            //създаваме вложени цикли, които да търсят всички възможни комбинации в диапазона
            //увеличаваме брояча на комбинациите с 1
            //намираме сборът на числата на всяка от комбинациите
            //проверяваме дали този сбор  е равен на магическото число
            //отпечатваме на конзолата съобщението o	"Combination N:{пореден номер} ({първото число} + {второ число} = {магическото число})"
            //ако е спираме програмата - вътрешен и външен цикъл

            for (int num1 = start; num1 <= stop; num1++)
            {
                for (int num2 = start; num2 <= stop; num2++)
                {
                    combination++;

                    int result = num1 + num2;

                    if (result == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({num1} + {num2} = {magicNumber})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
                //проверяваме дали сме намерили магическото число
                //ако не сме - o	"{броят на всички комбинации} combinations - neither equals {магическото число}"
            if (!flag)
            {
                    Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}

