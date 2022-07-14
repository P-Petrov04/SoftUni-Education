using System;

namespace Problem_13___Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            
            double maxBonus = 0;
            int maxLectures = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                int attendanceOfEachStudent = int.Parse(Console.ReadLine());

                double bonus = (double)attendanceOfEachStudent / countOfLectures * (5 + additionalBonus);
                if (bonus > maxBonus)
                {
                    maxBonus = bonus;
                    maxLectures = attendanceOfEachStudent;
                }
            }

            maxBonus = Math.Ceiling(maxBonus);
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxLectures} lectures.");
        }
    }
}
