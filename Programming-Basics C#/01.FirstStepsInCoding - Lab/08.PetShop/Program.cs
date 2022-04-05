using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodForDogs = int.Parse(Console.ReadLine());
            int foodForCats = int.Parse(Console.ReadLine());

            double fullPrice = foodForDogs * 2.50 + foodForCats * 4;
            Console.WriteLine($"{fullPrice} lv.");
        }
    }
}
