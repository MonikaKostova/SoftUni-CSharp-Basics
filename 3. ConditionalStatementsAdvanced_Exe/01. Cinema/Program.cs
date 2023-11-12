using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. тип прожекция, брой редове и колони
            string ticketType = Console.ReadLine(); 
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            //2. колко свободни места има 
            double income = row * column;

            //3. проверка каква е прожекцията
            // премиера =12, нормална =7,50, намалена 5 income=income*12
            if (ticketType == "Premiere") { income *= 12; }
            else if (ticketType == "Normal") { income *= 7.50; }
            else { income *= 5; }
            //4. резултатаConsole.WriteLine("{0:f2} leva", income).
            Console.WriteLine("{0:f2} leva", income);
        }
        
    }
}
