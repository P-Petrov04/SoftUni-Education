using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = 0; i < rooms; i++)
            {
                Console.Write($"L{floors}{i} ");
                
            }
            Console.WriteLine();
            if (floors > 1)
            {
                for (int i = floors - 1; i >= 1; i--)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < rooms; j++)
                        {
                            Console.Write($"O{i}{j} ");  
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int j = 0; j < rooms; j++)
                        {
                            Console.Write($"A{i}{j} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            
        }
    }
}
