using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfBarrel = int.Parse(Console.ReadLine());
            int[] inputBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(inputBullets);
            Queue<int> locks = new Queue<int>(inputLocks);
            int counter = sizeOfBarrel;
            int sum = 0;
            while (bullets.Count > 0 && locks.Count > 0)
            {
                int currBullet = bullets.Pop();
                int currLock = locks.Peek();
                
                if (currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                counter--;
                sum += priceOfBullet;
                if (counter == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    counter = sizeOfBarrel;
                }
            }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - sum}");
            }
        }
    }
}
