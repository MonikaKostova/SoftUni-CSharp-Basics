using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //създаваме променливи за вход от конзолата, дестинация, END, бюджет
            string destination = Console.ReadLine(); ;
            double budget = 0;

            // създаваме цикъл, който да се изпълнява докато входът не е END
            while (destination != "End")
            {
                // присвояваме на дестинацията = вход
                // четем необходим бюджет за конкретната дестинация

                budget = double.Parse(Console.ReadLine());

                while (budget > 0)
                {
                    // съзадаве вътрешен  while цикъл, който да се изпълнява докато не спести достатъчно
                    // изваждаме от необходимия бюджет парите, които спестява

                    budget -= double.Parse(Console.ReadLine());

                }
                // като спести достатъчно отпечатваме на конзолата "Going to {дестинацията}!" 
                // четем нов ход от конзолата

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();

            }
        }
    }
}
