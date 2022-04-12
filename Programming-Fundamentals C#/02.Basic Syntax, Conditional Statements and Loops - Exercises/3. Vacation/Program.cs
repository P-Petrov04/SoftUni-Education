using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double priceForOnePerson = 0;
            double discount = 0;

            if (typeGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    priceForOnePerson = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceForOnePerson = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceForOnePerson = 10.46;
                }
            }
            else if (typeGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    priceForOnePerson = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceForOnePerson = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceForOnePerson = 16;
                }
            }
            else if (typeGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    priceForOnePerson = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceForOnePerson = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    priceForOnePerson = 22.50;
                }
            }

            double priceForGroup = countPeople * priceForOnePerson;
            double finalPrice = 0;

            if (typeGroup == "Students" && countPeople >= 30)
            {
                discount = 0.15;
                finalPrice = priceForGroup - (priceForGroup * discount);
            }
            else if (typeGroup == "Business" && countPeople >= 100)
            {
                discount = 10 * priceForOnePerson;
                finalPrice = priceForGroup - discount;
            }
            else if (typeGroup == "Regular" && countPeople >= 10 && countPeople <= 20)
            {
                discount = 0.05;
                finalPrice = priceForGroup - (priceForGroup * discount);
            }
            else
            {
                finalPrice = priceForGroup;
            }

            Console.WriteLine($"Total price: {finalPrice:f2}");
        }
    }
}
