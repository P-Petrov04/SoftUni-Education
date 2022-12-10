using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroesArgs = new Dictionary<string, List<int>>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string heroName = heroInfo[0];
                int heroHP = int.Parse(heroInfo[1]);
                int heroMana = int.Parse(heroInfo[2]);

                heroesArgs.Add(heroName, new List<int>());
                heroesArgs[heroName].Add(heroHP);
                heroesArgs[heroName].Add(heroMana);
            }

            string commandInfo = Console.ReadLine();
            while (commandInfo != "End")
            {
                string[] commandArgs = commandInfo
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string typeCommand = commandArgs[0];
                if (typeCommand == "CastSpell")
                {
                    string heroName = commandArgs[1];
                    int neededMana = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];

                    if (neededMana <= heroesArgs[heroName][1])
                    {
                        heroesArgs[heroName][1] -= neededMana;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesArgs[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (typeCommand == "TakeDamage")
                {
                    string heroName = commandArgs[1];
                    int damage = int.Parse(commandArgs[2]);
                    string attacker = commandArgs[3];

                    heroesArgs[heroName][0] -= damage;
                    if (heroesArgs[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesArgs[heroName][0]} HP left!");
                    }
                    else
                    {
                        heroesArgs.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (typeCommand == "Recharge")
                {
                    string heroName = commandArgs[1];
                    int manaToRecharge = int.Parse(commandArgs[2]);
                    int originalMana = heroesArgs[heroName][1];

                    heroesArgs[heroName][1] += manaToRecharge;
                    if (heroesArgs[heroName][1] > 200)
                    {
                        heroesArgs[heroName][1] = 200;
                    }
                    Console.WriteLine($"{heroName} recharged for {heroesArgs[heroName][1] - originalMana} MP!");
                }
                else if (typeCommand == "Heal")
                {
                    string heroName = commandArgs[1];
                    int healthToRecover = int.Parse(commandArgs[2]);
                    int originalHealth = heroesArgs[heroName][0];

                    heroesArgs[heroName][0] += healthToRecover;
                    if (heroesArgs[heroName][0] > 100)
                    {
                        heroesArgs[heroName][0] = 100;
                    }
                    Console.WriteLine($"{heroName} healed for {heroesArgs[heroName][0] - originalHealth} HP!");
                }

                commandInfo = Console.ReadLine();
            }

            foreach (var hero in heroesArgs)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"HP: {hero.Value[0]}");
                Console.WriteLine($"MP: {hero.Value[1]}");
            }
        }
    }
}
