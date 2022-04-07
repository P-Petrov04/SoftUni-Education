using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int year = 1;
            double totalGradeInYears = 0;
            int fails = 0;

            while (year <= 12) 
            {
                double grade = double.Parse(Console.ReadLine());

                if(grade < 4.00)
                {
                    fails++;

                    if (fails == 2)
                    {
                        break;
                    }

                    continue;
                }

                totalGradeInYears += grade;
                year++;
            }

            if (fails == 2)
            {
                Console.WriteLine($"{name} has been excluded at {year} grade");
            }
            else
            {
                double averageGrade = totalGradeInYears / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
