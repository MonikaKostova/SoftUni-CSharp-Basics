using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. четем от конзолата заглавието

            string favouriteBook = Console.ReadLine();

            int count = 0;
            string input = Console.ReadLine();

            //2. създаваме while цикъл, който да се изпълнява докато
            // не свършат всички книги в списъка
            // а ако я намери ще спрем цикъла вътре в него

            while (input != "No More Books")
            {
                //3. четем име от конзолата име на следваща книга
                // проверяваме дали това е любимата книга
                // ако е спираме цикъла
                    if (input == favouriteBook)
                    {
                        break;
                    }
                    // ако не е увеличаваме брояча на книгите, които сме проверили  
                    count++;
                    // четем от конзолата следващо заглавие
                    input = Console.ReadLine();
            }

            //4. извеждаме изхода на конзолата
            if (input == favouriteBook)
            {
                //ако сме намерили книгата
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {//ако не сме намерили книгата
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
