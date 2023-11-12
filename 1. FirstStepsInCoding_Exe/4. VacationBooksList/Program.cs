using System;

namespace P04._VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int page = int.Parse(Console.ReadLine());  
            int pagePerHour = int.Parse(Console.ReadLine());    
            int day = int.Parse(Console.ReadLine());    

            int totalHours = page/pagePerHour;

            int hoursPrDay = totalHours/day;   

            Console.WriteLine(hoursPrDay);
        }
    }
}
