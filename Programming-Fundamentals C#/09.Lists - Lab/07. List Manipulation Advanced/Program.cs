using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool isChanged = false;
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split();
                string typeCommand = command[0];
                if (typeCommand == "Add")
                {
                    int numberToAdd = int.Parse(command[1]);
                    numbers.Add(numberToAdd);
                    isChanged = true;
                }
                else if (typeCommand == "Remove")
                {
                    int numberToRemove = int.Parse(command[1]);
                    numbers.Remove(numberToRemove);
                    isChanged = true;
                }
                else if (typeCommand == "RemoveAt")
                {
                    int indexOfNum = int.Parse(command[1]);
                    numbers.RemoveAt(indexOfNum);
                    isChanged = true;
                }
                else if (typeCommand == "Insert")
                {
                    int numberToInsert = int.Parse(command[1]);
                    int indexOfNum = int.Parse(command[2]);
                    numbers.Insert(indexOfNum, numberToInsert);
                    isChanged = true;
                }
                else if (typeCommand == "Contains")
                {
                    int checkedNumber = int.Parse(command[1]);
                    if (numbers.Contains(checkedNumber))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (typeCommand == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (typeCommand == "PrintOdd")
                {
                    List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (typeCommand == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (typeCommand == "Filter")
                {
                    List<int> filteredNumbers = new List<int>();
                    string condition = command[1];
                    int number = int.Parse(command[2]);
                    if (condition == "<")
                    {
                        filteredNumbers = numbers.FindAll(x => x < number);
                        Console.WriteLine(string.Join(" ", filteredNumbers));
                    }
                    else if (condition == ">")
                    {
                        filteredNumbers = numbers.FindAll(x => x > number);
                        Console.WriteLine(string.Join(" ", filteredNumbers));
                    }
                    else if (condition == "<=")
                    {
                        filteredNumbers = numbers.FindAll(x => x <= number);
                        Console.WriteLine(string.Join(" ", filteredNumbers));
                    }
                    else if (condition == ">=")
                    {
                        filteredNumbers = numbers.FindAll(x => x >= number);
                        Console.WriteLine(string.Join(" ", filteredNumbers));
                    }
                }

                input = Console.ReadLine();
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
