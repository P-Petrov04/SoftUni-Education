using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;
            int allClimbers = 0;

            for (int i = 1; i <= groups; i++)
            {
                int membersOfGroup = int.Parse(Console.ReadLine());

                allClimbers += membersOfGroup;

                if (membersOfGroup <= 5)
                {
                    group1 += membersOfGroup;
                }
                else if (membersOfGroup < 13)
                {
                    group2 += membersOfGroup;
                }
                else if (membersOfGroup < 26)
                {
                    group3 += membersOfGroup;
                }
                else if (membersOfGroup < 41)
                {
                    group4 += membersOfGroup;
                }
                else
                {
                    group5 += membersOfGroup;
                }
            }

            Console.WriteLine($"{(1.0 * group1 / allClimbers * 100):f2}%");
            Console.WriteLine($"{(1.0 * group2 / allClimbers * 100):f2}%");
            Console.WriteLine($"{(1.0 * group3 / allClimbers * 100):f2}%");
            Console.WriteLine($"{(1.0 * group4 / allClimbers * 100):f2}%");
            Console.WriteLine($"{(1.0 * group5 / allClimbers * 100):f2}%");
        }
    }
}
