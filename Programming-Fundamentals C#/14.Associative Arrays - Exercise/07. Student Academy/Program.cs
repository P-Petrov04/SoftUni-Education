using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairsOfRows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsArgs = new Dictionary<string, List<double>>();

            for (int i = 1; i <= pairsOfRows; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsArgs.ContainsKey(studentName))
                {
                    studentsArgs[studentName].Add(grade);
                }
                else
                {
                    studentsArgs.Add(studentName, new List<double>(){ grade });
                }
            }
            Dictionary<string, double> secondDictionary = new Dictionary<string, double>();

            foreach (var item in studentsArgs)
            {
                secondDictionary.Add(item.Key, item.Value.Average());
            }

            foreach (var item in secondDictionary)
            {
                if (!(item.Value >= 4.50))
                {
                    secondDictionary.Remove(item.Key);
                }
                else
                {
                    Console.WriteLine($"{item.Key} -> {item.Value:f2}");
                }
            }
        }
    }
}
