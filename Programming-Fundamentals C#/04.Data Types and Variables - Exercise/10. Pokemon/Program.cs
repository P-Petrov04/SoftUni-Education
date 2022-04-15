using System;

namespace _10._Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokedCounter = 0;
            int originalPokePower = pokePower;
            while (distance <= pokePower)
            {
                pokePower = pokePower - distance;
                pokedCounter++;
                if (pokePower <= 0)
                {
                    break;
                }
                if (originalPokePower / pokePower == 2 && originalPokePower % pokePower == 0 && exhaustionFactor != 0)
                {
                    pokePower = pokePower / exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedCounter);
        }
    }
}
