using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double myMoney = double.Parse(Console.ReadLine());
            string gameName = Console.ReadLine();
            double gamePrice = 0;
            double totalSpend = 0;

            while (gameName != "Game Time")
            {
                if (gameName == "OutFall 4")
                {
                    gamePrice = 39.99;
                    if (myMoney >= gamePrice)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        myMoney -= gamePrice;
                        totalSpend += gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "CS: OG")
                {
                    gamePrice = 15.99;
                    if (myMoney >= gamePrice)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        myMoney -= gamePrice;
                        totalSpend += gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                    if (myMoney >= gamePrice)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        myMoney -= gamePrice;
                        totalSpend += gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Honored 2")
                {
                    gamePrice = 59.99;
                    if (myMoney >= gamePrice)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        myMoney -= gamePrice;
                        totalSpend += gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    gamePrice = 29.99;
                    if (myMoney >= gamePrice)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        myMoney -= gamePrice;
                        totalSpend += gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                    if (myMoney >= gamePrice)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        myMoney -= gamePrice;
                        totalSpend += gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                    gameName = Console.ReadLine();
                    continue;
                }

                if (myMoney == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                gameName = Console.ReadLine();
            }
            if (gameName == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${myMoney:f2}");
            }
        }
    }
}
