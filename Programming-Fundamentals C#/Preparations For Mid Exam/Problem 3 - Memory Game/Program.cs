using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();
            int countOfMoves = 0;
            
            while (input != "end")
            {
                int[] indexses = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int firstIndex = indexses[0];
                int secondIndex = indexses[1];

                countOfMoves++;
                if (firstIndex == secondIndex || firstIndex < 0 || secondIndex < 0 || firstIndex >= elements.Count || secondIndex >= elements.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int indexToInsert = elements.Count / 2;
                    elements.Insert(indexToInsert, "-" + countOfMoves + "a");
                    elements.Insert(indexToInsert, "-" + countOfMoves + "a");
                    input = Console.ReadLine();
                    continue;
                }
                
                else if (elements[firstIndex] == elements[secondIndex])
                {
                    if (firstIndex > secondIndex)
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
                        elements.RemoveAt(firstIndex);
                        elements.RemoveAt(secondIndex);
                    }
                    else
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
                        elements.RemoveAt(secondIndex - firstIndex);
                        elements.RemoveAt(firstIndex);
                    }
                }
                    
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {countOfMoves} turns!");
                    break;
                }

                input = Console.ReadLine();
            }

            if(elements.Count != 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
    }
}
