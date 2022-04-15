using System;

namespace _9._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spice = 0;
            int spiceAfterWorkDay = 0;
            int allSpice = 0;
            while (startingYield >= 100)
            {
                daysCounter++;
                spice += startingYield;
                if (spice >= 26)
                {
                    spiceAfterWorkDay = spice - 26;
                    allSpice += spiceAfterWorkDay;
                }
                startingYield -= 10;
                spice = 0;
            }
            int spiceAfteMineIsOut = allSpice;
            if (spiceAfterWorkDay >= 26)
            {
                spiceAfteMineIsOut -= 26;
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(spiceAfteMineIsOut);

            
        }
    }
}
