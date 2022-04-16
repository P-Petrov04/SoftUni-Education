using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int counterForOpen = 0;
            int counterForClose = 0;
            for (int i = 1; i <= lines; i++)
            {
                string str = Console.ReadLine();
                if (str == "(")
                {
                    counterForOpen++;
                }
                else if (str == ")")
                {
                    counterForClose++;
                    if (counterForOpen - counterForClose != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            
            if (counterForOpen == counterForClose)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
