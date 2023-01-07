using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int myFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ordersToServe = new Queue<int>(orders);
            int biggestOrder = ordersToServe.Max();
            Console.WriteLine(biggestOrder);

            for (int i = 0; i < orders.Length; i++)
            {
                int currOrder = ordersToServe.Peek();
                if (myFood >= currOrder)
                {
                    ordersToServe.Dequeue();
                    myFood -= currOrder;
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", ordersToServe)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
