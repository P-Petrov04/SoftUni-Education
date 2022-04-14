using System;

namespace _2._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britishPounds = decimal.Parse(Console.ReadLine());
            decimal usDollars = britishPounds * (decimal)1.31;
            Console.WriteLine($"{usDollars:f3}");
        }
    }
}
