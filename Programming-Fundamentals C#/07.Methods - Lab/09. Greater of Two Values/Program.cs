using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();

            if (valueType == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(num1 , num2));
            }
            else if (valueType == "char")
            {
                char chr1 = char.Parse(Console.ReadLine());
                char chr2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(chr1, chr2));
            }
            else if (valueType == "string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();
                Console.WriteLine(GetMax(text1, text2));
            } 
            

        }

        static int GetMax(int first, int second)
        {
            return first >= second ? first : second;
        }
        static char GetMax(char first, char second)
        {
            return first >= second ? first : second;
        }
        static string GetMax(string first, string second)
        {
            return first.CompareTo(second) >= 0 ? first : second;
        }
    }
}
