using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            for (int i = 1111; i <= 9999; i++)
            {
                int currNum = i;
                while (currNum != 0)
                {
                    int lastNum = currNum % 10;
                    if (lastNum == 0)
                    {
                        currNum = currNum / 10;
                        isSpecial = false;
                        break;
                    }
                    else if (n % lastNum == 0)
                    {
                        isSpecial = true;
                    }
                    else
                    {
                        isSpecial = false;
                        break;
                    }
                    currNum = currNum / 10;
                }
                if (isSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
