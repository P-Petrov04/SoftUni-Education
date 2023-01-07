using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputSongs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songs = new Queue<string>(inputSongs);
            while (songs.Count > 0)
            {
                string commandInfo = Console.ReadLine();

                
                if (commandInfo.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if (commandInfo.Contains("Add"))
                {
                    string song = commandInfo.Substring(4);
                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                        continue;
                    }

                    songs.Enqueue(song);
                }
                else if (commandInfo.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

            }

            Console.WriteLine("No more songs!");
        }
    }
}
