using System;

namespace _05Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());//необходими часове за изработване на проекта; 90
            int daysGiven = int.Parse(Console.ReadLine()); // дните с които фирмата разполага; 7
            int numOvertimeWorkers = int.Parse(Console.ReadLine()); //брой на работниците които работят извънредно; 3

            double hoursWorked = Math.Floor((daysGiven * 8 * 0.9) + (numOvertimeWorkers * 2 * daysGiven)); //7*8*0.9 + 3*2*7 = 92,4

            if (hoursWorked >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{hoursWorked - hoursNeeded} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded - hoursWorked} hours needed.");
            }

        }
    }
}
