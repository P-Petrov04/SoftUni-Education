using System;
using System.Collections.Generic;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> newString = new List<char>();
            int explosionPower = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentCh = text[i];
                if (currentCh == '>')
                {
                    newString.Add(currentCh);
                    double powerOfExplosion = char.GetNumericValue(text[i + 1]);
                    explosionPower += (int)powerOfExplosion;
                }
                else
                {
                    if (explosionPower == 0)
                    {
                        newString.Add(currentCh);
                    }
                    else
                    {
                        explosionPower--;
                    }
                }
            }

            string finalString = string.Join("", newString);
            Console.WriteLine(finalString);
        }
    }
}
