using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int sum = num2;

            while (sum < number)
            {
                num2 = int.Parse(Console.ReadLine());
                sum += num2;
            }
            Console.WriteLine(sum);  
        }
    } 
}
