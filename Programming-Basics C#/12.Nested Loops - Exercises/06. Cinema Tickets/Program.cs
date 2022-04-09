using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double allTickets = 0;
            double countStudentTickets = 0;
            double countStandartTickets = 0;
            double countKidTickets = 0;
            while (true)
            {
                string filmName = Console.ReadLine();
                if (filmName == "Finish")
                {
                    break;
                }
                double allFreeSpace = int.Parse(Console.ReadLine());
                double nonFreeSpaces = 0;
                while (nonFreeSpaces != allFreeSpace)
                {
                    string typeTicket = Console.ReadLine();
                    if (typeTicket == "End")
                    {
                        break;
                    }
                    allTickets++;
                    nonFreeSpaces++;
                    if (typeTicket == "student")
                    {
                        countStudentTickets++;
                    }
                    else if (typeTicket == "standard")
                    {
                        countStandartTickets++;
                    }
                    else if (typeTicket == "kid")
                    {
                        countKidTickets++;
                    }
                }

                Console.WriteLine($"{filmName} - {(nonFreeSpaces / allFreeSpace * 100):f2}% full.");
            }

            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{(countStudentTickets / allTickets * 100):f2}% student tickets.");
            Console.WriteLine($"{(countStandartTickets / allTickets * 100):f2}% standard tickets.");
            Console.WriteLine($"{(countKidTickets / allTickets * 100):f2}% kids tickets.");
        }
    }
}
