using System;

namespace P01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четем времето на тримата състезатели
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            //намираме за какво общо време са финиширали в секунди
            int totalTime = first + second + third;

            //намираме колко мини секуди са това общо
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            //=>ако минутите са „10 да ги изведен с водеща нула
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            //извеждаме на конзолата резултата
            else
            {

                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
