using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while(input != "end")
            {
                string[] command = input.Split(); 
                string typeCommand = command[0];
                if (typeCommand == "Add")
                {
                    int numberToAdd = int.Parse(command[1]);
                    numbers.Add(numberToAdd);
                }
                else if (typeCommand == "Remove")
                {
                    int numberToRemove = int.Parse(command[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (typeCommand == "RemoveAt")
                {
                    int indexOfNum = int.Parse(command[1]);
                    numbers.RemoveAt(indexOfNum);
                }
                else if (typeCommand == "Insert")
                {
                    int numberToInsert = int.Parse(command[1]);
                    int indexOfNum = int.Parse(command[2]);
                    numbers.Insert(indexOfNum, numberToInsert);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
