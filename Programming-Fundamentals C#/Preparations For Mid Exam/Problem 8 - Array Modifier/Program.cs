using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8___Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();
                string typeOfCommand = command[0];

                if (typeOfCommand == "swap")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);

                    int valueOfIndex1 = numbers[index1];
                    int valueOfIndex2 = numbers[index2];

                    numbers.RemoveAt(index1);
                    numbers.Insert(index1, valueOfIndex2);
                    numbers.RemoveAt(index2);
                    numbers.Insert(index2, valueOfIndex1);
                }
                else if (typeOfCommand == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);

                    int valueOfIndex1 = numbers[index1];
                    int valueOfIndex2 = numbers[index2];
                    int newValueOfIndex1 = valueOfIndex1 * valueOfIndex2;

                    numbers.RemoveAt(index1);
                    numbers.Insert(index1, newValueOfIndex1);
                }
                else if (typeOfCommand == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                         numbers[i] -= 1;
                        
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
