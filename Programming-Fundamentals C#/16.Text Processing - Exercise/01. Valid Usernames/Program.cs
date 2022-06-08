using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            bool isValid = false;
            List<string> validUsernames = new List<string>();

            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    foreach (char ch in username)
                    {
                        if (char.IsLetterOrDigit(ch))
                        {
                            isValid = true;
                        }
                        else if (ch == '-' || ch == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }

                    }
                    if (isValid == true)
                    {
                        validUsernames.Add(username);
                    }
                }
            }

            foreach (string username in validUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
