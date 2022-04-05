using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pageInBook = int.Parse(Console.ReadLine());
            int pagePerHour = int.Parse(Console.ReadLine());
            int daysForBook = int.Parse(Console.ReadLine());

            //Общо време за четене на книгата: 212 страници / 20 страници за час = 10 часа общо
            //Необходимите часове на ден: 10 часа / 2 дни = 5 часа на ден
            int timeForBook = pageInBook / pagePerHour;
            int hoursPerDay = timeForBook / daysForBook;

            Console.WriteLine(hoursPerDay);
        }
    }
}
