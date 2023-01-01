using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieceArg = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string name = pieceArg[0];
                string composer = pieceArg[1];
                string key = pieceArg[2];

                pieces.Add(name, new List<string>());
                pieces[name].Add(composer);
                pieces[name].Add(key);
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] commandArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                string typeCommand = commandArgs[0];
                if (typeCommand == "Add")
                {
                    string name = commandArgs[1];
                    string composer = commandArgs[2];
                    string key = commandArgs[3];

                    if (pieces.Keys.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the collection!");
                    }
                    else
                    {
                        pieces.Add(name, new List<string>());
                        pieces[name].Add(composer);
                        pieces[name].Add(key);

                        Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
                    } 
                }
                else if (typeCommand == "Remove")
                {
                    string name = commandArgs[1];
                    if (pieces.Keys.Contains(name))
                    {
                        pieces.Remove(name);
                        Console.WriteLine($"Successfully removed {name}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                }
                else if (typeCommand == "ChangeKey")
                {
                    string name = commandArgs[1];
                    string newKey = commandArgs[2];

                    if (pieces.Keys.Contains(name))
                    {
                        pieces[name].RemoveAt(1);
                        pieces[name].Add(newKey);
                        Console.WriteLine($"Changed the key of {name} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
