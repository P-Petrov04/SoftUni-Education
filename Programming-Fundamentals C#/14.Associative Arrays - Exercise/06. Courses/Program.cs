using System;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> courseInformation = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] courseArg = input.Split(" : ");

                string courseName = courseArg[0];
                string studentName = courseArg[1];

                if (courseInformation.ContainsKey(courseName))
                {
                    courseInformation[courseName].Add(studentName);
                }
                else
                {
                    courseInformation.Add(courseName, new List<string>() { studentName });
                }

                input = Console.ReadLine();
            }

            foreach (var item in courseInformation)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                string[] students = item.Value.ToArray();
                foreach (string student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
