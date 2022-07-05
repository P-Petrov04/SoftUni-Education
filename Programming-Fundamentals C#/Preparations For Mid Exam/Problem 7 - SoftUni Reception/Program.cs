using System;

namespace Problem_7___SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int allEmployeesPerHour = employee1 + employee2 + employee3;
            int allHours = 0;
            int hoursInRow = 0;
            int breakHours = 0;
            while (studentsCount > 0)
            {
                if (hoursInRow == 3)
                {
                    breakHours++;
                    hoursInRow = 0;
                    continue;
                }
                studentsCount -= allEmployeesPerHour;
                allHours++;
                hoursInRow++;
            }

            Console.WriteLine($"Time needed: {allHours + breakHours}h.");
        }
    }
}
