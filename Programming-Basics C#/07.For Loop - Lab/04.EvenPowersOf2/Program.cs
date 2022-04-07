using System;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i <= text.Length - 1; i++)          //for (int i = 0; i < text.Length; i++
            {                                                   //char letter = text[i]
                Console.WriteLine(text[i]);                     //cw(letter)
            }
        }
    }
}
