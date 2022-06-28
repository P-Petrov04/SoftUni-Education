using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> runnersArg = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                StringBuilder nameFromInput = new StringBuilder();
                int distance = 0;
                foreach (char ch in input)
                {
                    if (char.IsLetter(ch))
                    {
                        nameFromInput.Append(ch);
                    }
                    else if (char.IsDigit(ch))
                    {
                        distance += (int)char.GetNumericValue(ch);
                    }
                }
                string name = nameFromInput.ToString();
                if (names.Contains(name))
                {
                    if (runnersArg.Keys.Contains(name))
                    {
                        runnersArg[name] += distance;
                    }
                    else
                    {
                        runnersArg.Add(name, distance);
                    }
                }

                input = Console.ReadLine();
            }

            var result = runnersArg.OrderByDescending(x => x.Value);
            int counter = 1;
            foreach (var runner in result)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {runner.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {runner.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {runner.Key}");
                }
                else
                {
                    break;
                }
                counter++;
            }
        }
    }
}
