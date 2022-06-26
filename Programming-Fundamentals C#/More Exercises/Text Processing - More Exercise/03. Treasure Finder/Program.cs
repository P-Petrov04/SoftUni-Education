using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> key = Console.ReadLine().Split().Select(int.Parse).ToList();

            string pattern = @".*\&(?<tr>[a-zA-Z]*)\&.*\<(?<coo>.*)\>";

            string input = Console.ReadLine();
            while (input != "find")
            {
                StringBuilder decriptedMessage = new StringBuilder();
                if (key.Count > input.Length)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        char currCh = input[i];
                        currCh = (char)(currCh - key[i]);
                        decriptedMessage.Append(currCh);
                    }
                }
                else
                {
                    double count = Math.Ceiling((double)input.Length / key.Count);
                    for (int i = 0; i < count; i++)
                    {
                        for (int j = 0; j < key.Count; j++)
                        {
                            if (input.Length == 0)
                            {
                                break;
                            }
                            char currCh = input[0];
                            currCh = (char)(currCh - key[j]);
                            decriptedMessage.Append(currCh);
                            input = input.Remove(0, 1);
                        }
                        if (input.Length == 0)
                        {
                            break;
                        }
                    }
                }

                Match match = Regex.Match(decriptedMessage.ToString(), pattern);
                if (match.Success)
                {
                    Console.WriteLine($"Found {match.Groups["tr"].Value} at {match.Groups["coo"].Value}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
