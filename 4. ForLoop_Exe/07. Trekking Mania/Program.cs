using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupNum = int.Parse(Console.ReadLine());
          
            int countMusala = 0;
            int countMonblan = 0;
            int countKilimandjaro = 0;
            int countK2 = 0;
            int countEverest = 0;

            double totalTourists = 0;

            for (int i = 1; i <= groupNum; i++)
            {
                int groupSize = int.Parse(Console.ReadLine());
                if (groupSize <= 5)
                {
                    countMusala += groupSize;  
                }
                else if (groupSize >= 6 && groupSize <= 12) 
                { 
                    countMonblan += groupSize;
                }
                else if (groupSize >= 13 && groupSize <= 25)
                {
                    countKilimandjaro += groupSize;
                }
                else if (groupSize >= 26 && groupSize <= 40)
                {
                    countK2 += groupSize;
                }
                else if (groupSize >= 41)
                {
                    countEverest += groupSize;
                }
            }
            totalTourists = countMusala + countMonblan + countKilimandjaro + countK2 + countEverest;
            double percentMusala = countMusala / totalTourists * 100;
            double percentMonblan = countMonblan / totalTourists * 100;
            double percentKilimandjaro = countKilimandjaro / totalTourists * 100;
            double percentK2 = countK2 / totalTourists * 100;
            double percentEverest = countEverest / totalTourists * 100;

            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonblan:f2}%");
            Console.WriteLine($"{percentKilimandjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
        }
    }
}
