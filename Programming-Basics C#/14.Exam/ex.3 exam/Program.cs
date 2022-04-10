using System;

namespace ex._3_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string typeSouvenir = Console.ReadLine();
            int countSouvenirs = int.Parse(Console.ReadLine());

            double money = 0;

            if (team == "Argentina")
            {
                if (typeSouvenir == "flags")
                {
                    money = 3.25;
                }
                else if (typeSouvenir == "caps")
                {
                    money = 7.20;
                }
                else if (typeSouvenir == "posters")
                {
                    money = 5.10;
                }
                else if (typeSouvenir == "stickers")
                {
                    money = 1.25;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (team == "Brazil")
            {
                if (typeSouvenir == "flags")
                {
                    money = 4.20;
                }
                else if (typeSouvenir == "caps")
                {
                    money = 8.50;
                }
                else if (typeSouvenir == "posters")
                {
                    money = 5.35;
                }
                else if (typeSouvenir == "stickers")
                {
                    money = 1.20;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (team == "Croatia")
            {
                if (typeSouvenir == "flags")
                {
                    money = 2.75;
                }
                else if (typeSouvenir == "caps")
                {
                    money = 6.90;
                }
                else if (typeSouvenir == "posters")
                {
                    money = 4.95;
                }
                else if (typeSouvenir == "stickers")
                {
                    money = 1.10;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (team == "Denmark")
            {
                if (typeSouvenir == "flags")
                {
                    money = 3.10;
                }
                else if (typeSouvenir == "caps")
                {
                    money = 6.50;
                }
                else if (typeSouvenir == "posters")
                {
                    money = 4.80;
                }
                else if (typeSouvenir == "stickers")
                {
                    money = 0.90;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
                return;
            }

            double rentMoney = money * countSouvenirs;
            Console.WriteLine($"Pepi bought {countSouvenirs} {typeSouvenir} of {team} for {rentMoney:f2} lv.");
        }
    }
}
