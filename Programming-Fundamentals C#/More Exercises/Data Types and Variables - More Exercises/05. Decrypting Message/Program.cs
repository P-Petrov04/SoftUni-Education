using System;
using System.Text;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            StringBuilder message = new StringBuilder();
            for (int i = 0; i < lines; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                message.Append((char)(ch + key));
            }

            Console.WriteLine(message);
        }
    }
}
