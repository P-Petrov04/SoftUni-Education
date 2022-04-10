using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            double allGrades = 0;

            double counterBad = 0;
            double counterBetter = 0;
            double counterGood = 0;
            double counterExcellent = 0;


            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                allGrades += grade;

                if (grade < 3.00)
                {
                    counterBad++;
                }
                else if (grade < 4.00)
                {
                    counterBetter++;
                }
                else if (grade < 5.00)
                {
                    counterGood++;
                }
                else
                {
                    counterExcellent++;
                }
            }

            averageGrade = allGrades / students;
            double percentBad = counterBad / students * 100;
            double percentBetter = counterBetter / students * 100;
            double percentGood = counterGood / students * 100;
            double percentExcelent = counterExcellent / students * 100;

            Console.WriteLine($"Top students: {percentExcelent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentGood:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentBetter:f2}%");
            Console.WriteLine($"Fail: {percentBad:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}
