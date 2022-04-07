using System;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int fines = 0;

            for (int i = 0; i < n; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    fines += 150;
                }
                else if (website == "Instagram")
                {
                    fines += 100;
                }
                else if (website == "Reddit")
                {
                    fines += 50;
                }
                if (salary <= fines)
                {
                    break;
                }
            }
            if (salary > fines)
            {
                Console.WriteLine($"{salary - fines}");
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
