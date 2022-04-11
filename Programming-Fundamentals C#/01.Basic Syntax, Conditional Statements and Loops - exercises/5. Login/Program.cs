using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";
            string input = "";
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            while (true)
            {
                input = Console.ReadLine();
                if (input != password)
                {
                    if (counter == 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    counter++;
                    Console.WriteLine("Incorrect password. Try again.");
                }

                else if (password == input)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }

            
           
        }
    }
}
