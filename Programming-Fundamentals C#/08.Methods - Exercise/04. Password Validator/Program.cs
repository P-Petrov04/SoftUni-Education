using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = PrintCorresponding(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool PrintCorresponding (string password)
        {
            bool isValid = true;
                if (!CheckPasswordLenght(password, isValid))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                    isValid = false;
                }
                if (!CheckContainsOnlyLetterAndDigits(password, isValid))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                }
                if (!CheckCountOfDigits(password, isValid))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    isValid = false;
                }

            return isValid;
        }
        static bool CheckPasswordLenght (string passwrod, bool isValid)
        {
            if (passwrod.Length >= 6 && passwrod.Length <= 10)
            {
                return true;
            }

            return false;
        }

        static bool CheckContainsOnlyLetterAndDigits (string password, bool isValid)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }
        static bool CheckCountOfDigits (string password, bool isValid)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }

            return digitsCount >= 2;
        }
    }
}
