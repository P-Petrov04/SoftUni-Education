using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@\#+(?<barCode>[A-Z][A-Za-z0-9]{4,}[A-Z])\@\#+";

            int countOfBarCodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfBarCodes; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string code = string.Empty;
                    foreach (char ch in input)
                    {
                        if (char.IsDigit(ch))
                        {
                            code += ch;
                        }
                    }
                    if (code == "")
                    {
                        code = "00";
                    }
                    Console.WriteLine($"Product group: {code}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
