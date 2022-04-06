using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int spendNights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
            double discount = 0;
            string sport = "";

            if (typeGroup == "boys" || typeGroup == "girls")
            {
                if (season == "Winter")
                {
                    pricePerNight = 9.60;
                }
                else if (season == "Spring")
                {
                    pricePerNight = 7.20;
                }
                else if (season == "Summer")
                {
                    pricePerNight = 15;
                }
            }
            else if (typeGroup == "mixed")
            {
                if (season == "Winter")
                {
                    pricePerNight = 10;
                }
                else if (season == "Spring")
                {
                    pricePerNight = 9.50;
                }
                else if (season == "Summer")
                {
                    pricePerNight = 20;
                }
            }
            if (studentsCount >= 50)
            {
                discount = 0.5;
            }
            else if (studentsCount >= 20)
            {
                discount = 0.15;
            }
            else if (studentsCount >= 10)
            {
                discount = 0.05;
            }

            double money = pricePerNight * spendNights * studentsCount;
            money = money - money * discount;

            if (typeGroup == "girls")
            {
                if (season == "Winter")
                {
                    sport = "Gymnastics";
                }
                else if (season == "Spring")
                {
                    sport = "Athletics";
                }
                else if (season == "Summer")
                {
                    sport = "Volleyball";
                }
            }
            else if (typeGroup == "boys")
            {
                if (season == "Winter")
                {
                    sport = "Judo";
                }
                else if (season == "Spring")
                {
                    sport = "Tennis";
                }
                else if (season == "Summer")
                {
                    sport = "Football";
                }
            }
            else if (typeGroup == "mixed")
            {
                if (season == "Winter")
                {
                    sport = "Ski";
                }
                else if (season == "Spring")
                {
                    sport = "Cycling";
                }
                else if (season == "Summer")
                {
                    sport = "Swimming";
                }
            }

            Console.WriteLine($"{sport} {money:f2} lv.");
        }
    }
}
