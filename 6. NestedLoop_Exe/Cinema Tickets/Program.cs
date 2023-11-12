using System;

namespace Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int countStudent = 0;
            int countStandard = 0;
            int countKid = 0;
            double countTakenSeats = 0;

            string movieName;
            while ((movieName = Console.ReadLine()) != "Finish")
            {
                double allSeats = int.Parse(Console.ReadLine());
                string ticketType;
                double currentTakenSeats = 0;

                while (currentTakenSeats < allSeats && ((ticketType = Console.ReadLine()) != "End"))
                {
                    switch (ticketType)
                    { 
                        
                            case "student":
                                countStudent++;
                                break;
                            case "standard":
                                countStandard++;
                                break;
                            case "kid":
                                countKid++;
                                break;
                    }
                        currentTakenSeats++;
                                          
                }
                double percentTakenSeats = currentTakenSeats / allSeats * 100;
                Console.WriteLine($"{movieName} - {percentTakenSeats:f2}% full.");

                countTakenSeats += currentTakenSeats;
            }
            double percentStudent = countStudent / countTakenSeats * 100 ;
            double percentStandard = countStandard / countTakenSeats * 100;
            double percentKid = countKid / countTakenSeats * 100;

            Console.WriteLine($"Total tickets: {countTakenSeats}");
            Console.WriteLine($"{percentStudent :f2}% student tickets.");
            Console.WriteLine($"{percentStandard :f2}% standard tickets.");
            Console.WriteLine($"{percentKid:f2}% kids tickets.");
        }
    }
}
