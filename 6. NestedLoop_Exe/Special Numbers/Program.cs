using System;

namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int j = 1; j <= 9; j++)
            {

                for (int m = 1; m <= 9; m++)
                {

                    for (int k = 1; k <= 9; k++)
                    {

                        for (int i = 1; i <= 9; i++)
                        {
                           if (num % m == 0 && num % j == 0&& num % k ==0 && num % i ==0)     
                            
                           
                            Console.Write($"{j}{m}{k}{i} ");
                        }
                    }
                }
            }
        }
        
    }
}
