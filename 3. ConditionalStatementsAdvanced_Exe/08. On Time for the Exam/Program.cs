using System;
using System.Collections;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.prochitame ot konzolata chas i minuti na izpita i pristigane
            // preobrazuvame chasovete i minutite samo v minuti
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());

            examMin = examMin + examHour * 60;

            //2. namirame razlikata mejdu minutite na izpita i minutite na prostigane
            int arrivalHour = int.Parse(Console.ReadLine());    
            int arrivalMin = int.Parse(Console.ReadLine()); 

            arrivalMin = arrivalMin + arrivalHour * 60; 

            //3.Namirame dali e zakasnql, podranil ili navreme
            int difference = examMin - arrivalMin;

            if (difference < 0)
            {
                Console.WriteLine("Late");

                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                else 
                {
                    Console.WriteLine($"{Math.Abs(difference / 60)}:{Math.Abs(difference % 60):D2} hours after the start");
                }

                //zakysnql s poveche ili tochno 1 chas
                //zakasnql s po-malko ot chas
            }
            else if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time"); 

                if(difference > 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                //ili tochno v chasa na izpita ili do 30 min predi izpita
            }
            else
            {
                Console.WriteLine("Early");
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference/60)}:{Math.Abs(difference % 60):D2} hours before the start");
                }
                //"Early" >>
                //zakysnql s poveche ili tochno 1 chas
                //zakasnql s po-malko ot chas
            }
        }
    }
}
