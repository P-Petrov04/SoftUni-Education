using System;

namespace _04.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char jender = char.Parse(Console.ReadLine());

            if (age >= 16)
            {
                if (jender == 'm')
                {
                    Console.WriteLine("Mr.");
                }
                else if (jender == 'f')
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (jender == 'm')
                {
                    Console.WriteLine("Master");
                }
                else if (jender == 'f')
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
