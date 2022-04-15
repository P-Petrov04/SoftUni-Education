using System;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCans = int.Parse(Console.ReadLine());

            float volume = 0;
            float MaxValue = 0;
            string bigestModel = "";

            for (int i = 1; i <= numberOfCans; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = (float)(Math.PI * Math.Pow(radius, 2) * height);
                if (volume > MaxValue)
                {
                    MaxValue = volume;
                    bigestModel = model;
                }
            }

            Console.WriteLine(bigestModel);
        }
    }
}
