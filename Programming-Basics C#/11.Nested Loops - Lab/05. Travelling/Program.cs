using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination != "End")
            {
                double currentMoney = 0;
                double budjed = double.Parse(Console.ReadLine());
                while (currentMoney < budjed)
                {
                    double money = double.Parse(Console.ReadLine());
                    currentMoney += money;
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
