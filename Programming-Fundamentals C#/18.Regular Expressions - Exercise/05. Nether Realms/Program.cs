using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> demonsNames = Console.ReadLine()
                .Split(",")
                .OrderBy(name => name)
                .ToList();
          
            for (int i = 0; i < demonsNames.Count; i++)
            {
                string currentDemonName = demonsNames[i].Trim();

                int health = GetHealth(currentDemonName);
                double damage = GetDamage(currentDemonName);

                Console.WriteLine($"{currentDemonName} - {health} health, {damage:f2} damage");
            }

        }

        static double GetDamage (string demonName)
        {
            string patternToMachDamage = @"[\d+(\.\d+)\+\-]+";

            double damage = 0;

            MatchCollection matches = Regex.Matches(demonName, patternToMachDamage);
            foreach (Match match in matches)
            {
                string currentCh = match.Value;

                if (currentCh.Contains("-"))
                {
                    double number;
                    double.TryParse(currentCh, out number);
                    damage += number;
                }
                else
                {
                    double valueOfCh = double.Parse(currentCh);
                    damage += valueOfCh;
                }
            }

            string patternToMultyOrDivin = @"[\*\/]";
            MatchCollection matches2 = Regex.Matches(demonName, patternToMultyOrDivin);
            foreach (Match match in matches2)
            {
                char currentCh = char.Parse(match.Value);
                if (currentCh == '*')
                {
                    damage *= 2;
                }
                else
                {
                    damage /= 2;
                }
            }

            return damage;
        }
        static int GetHealth (string demonName)
        {
            string patternToMachHealth = @"[^0-9\+\-\*\/\.]";
         
            int health = 0;

            MatchCollection matchCharsForHealth = Regex.Matches(demonName, patternToMachHealth);
            foreach (Match match in matchCharsForHealth)
            {
                char currentCh = char.Parse(match.Value);
                health += currentCh;
            }

            return health;
        }
    }
}
