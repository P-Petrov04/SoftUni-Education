using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int treated = 0;
            int untreated = 0;
            int counter = 0;

            for (int day = 1; day <= period; day++)
            {
                counter++;
                if (counter == 3 && untreated > treated)
                {
                    doctors++;
                    counter = 0;
                }
                int patients = int.Parse(Console.ReadLine());
                if (patients <= doctors)
                {
                    treated += patients;
                }
                else
                {
                    treated += doctors;
                    untreated += patients - doctors;
                }
                
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
