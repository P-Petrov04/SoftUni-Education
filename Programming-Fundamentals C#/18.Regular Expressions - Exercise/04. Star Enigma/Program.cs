using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfMessages = int.Parse(Console.ReadLine());

            List<string> attackPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            
            for (int i = 0; i < countOfMessages; i++)
            {
                string input = Console.ReadLine();

                string patternToCheckValidation = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(\d+)[^\@\-\!\:\>]*?\!(?<attackType>A|D)\![^\@\-\!\:\>]*?\-\>(\d+)";
                string decriptedMessage = GetDecriptedMessage(input);
                Match match = Regex.Match(decriptedMessage, patternToCheckValidation);
                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    string attType = match.Groups["attackType"].Value;
                    if (attType == "A")
                    {
                        attackPlanets.Add(planet);
                    }
                    else if (attType == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            OutPut(attackPlanets, destroyedPlanets);
        }

        static void OutPut (List<string> attPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attPlanets.Count}");
            foreach (string planet in attPlanets.OrderBy(name => name))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (string planet in destroyedPlanets.OrderBy(name => name))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        static string GetDecriptedMessage (string input)
        {
            string patterToFindSymbols = "[star]";
            StringBuilder decriptedMessage = new StringBuilder();

            MatchCollection matchesSymbols = Regex.Matches(input, patterToFindSymbols, RegexOptions.IgnoreCase);
            foreach (char ch in input)
            {
                char newChar = (char)(ch - matchesSymbols.Count);
                decriptedMessage.Append(newChar);
            }

            return decriptedMessage.ToString();
        }
    }
}
