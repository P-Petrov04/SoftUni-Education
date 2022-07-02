using System;

namespace Problem_1___Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal totalTaxes = 0;
            decimal allPrice = 0;
            while (input != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
                decimal taxes = 0.2M;
                allPrice += price;
                totalTaxes += price * taxes;

                input = Console.ReadLine();
            }
            decimal totalPrice = allPrice + totalTaxes;
            if (input == "special")
            {
                totalPrice = totalPrice - totalPrice * (decimal)0.1;
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {allPrice:f2}$");
            Console.WriteLine($"Taxes: {totalTaxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");

        }
    }
}
