using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace _05._Journey
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //1. прочитаме n1, n2 и оператора

                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                char operation = char.Parse(Console.ReadLine());

                //2. проверяваме дали операторът е if(+,-,*)
                //"{N1}+/-/*{N2} = {rezultat} chetno ili nechetno
                //или else(/,%)
                // dali n2=0
                // pri n2=0 >> "Cannot divide{N1}by zero"
                // pri / >> "{N1}/{N2} = {rezultat}
                // pri % >> "{N1}%{N2} ={ostatyk}

                if (operation == '+' || operation == '-' || operation == '*')
                {
                    int result;

                    if (operation == '+') { result = num1 + num2; }
                    else if (operation == '-') { result = num1 - num2; }
                    else { result = num1 * num2; }

                    string evenOrOdd = "odd";
                    if (result % 2 == 0) { evenOrOdd = "even"; }

                    Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");

                }

                else
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else if (operation == '/')
                    {
                        Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    }
                }
            }
        }
    }

}
    }
}
