using System;

namespace _08.CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            // Monday Tuesday Wednesday Thursday    Friday Saturday    Sunday
            //  12       12      14        14         12      16         16

            string day = Console.ReadLine();
            int ticket = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                ticket = 12;
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                ticket = 14;
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                ticket = 16;
            }
            Console.WriteLine(ticket);
        }
    }
}
