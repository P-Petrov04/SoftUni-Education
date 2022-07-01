using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@(?<name>[A-Za-z]+)([^\@|\-|\!|\:|\>]*?)\!(?<type>[G|N]{1})\!";
            List<string> goodChildren = new List<string>();
            int key = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int count = 0;
            while (input != "end")
            {
                StringBuilder decriptedMessage = new StringBuilder();
                foreach (char ch in input)
                {
                    char newCh = (char)(ch - key);
                    decriptedMessage.Append(newCh);
                }
                string message = decriptedMessage.ToString();
                Match match = Regex.Match(message, pattern);
                if (match.Success)
                {
                    if (match.Groups["type"].Value == "G")
                    {
                        goodChildren.Add(match.Groups["name"].Value);
                    }
                }

                input = Console.ReadLine();
            }

            if (goodChildren.Count != 0)
            {
                foreach (string child in goodChildren)
                {
                    Console.WriteLine(child);
                }
            }
        }
    }
}
