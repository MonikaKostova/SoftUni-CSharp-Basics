using System;

namespace P03._DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // da pro4etem ot konzolata
            // suma - double
            //srok - int
            // godiwen procent - double

            // izqisl[vame po formulata 
            //сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            // izvejdame sumata na konzolata
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine())/100;

            double sum = deposit + term * ((deposit * rate) / 12);

            Console.WriteLine(sum);
        }
    }
}
