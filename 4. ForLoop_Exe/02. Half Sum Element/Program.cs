using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            // четем число от конзолата
            // добавяме го към сумата 
            // проверяваме дали е най-голямото
            // ако е най-голямото = maxNum
            int num =0;

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }

            }
            if (max == sum - max)
                //sum -= max
                //sum == max
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum - max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - max - max)}");
            }
        }
    }
}
