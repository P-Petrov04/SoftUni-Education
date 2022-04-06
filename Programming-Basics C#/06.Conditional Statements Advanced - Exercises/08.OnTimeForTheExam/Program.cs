using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minOfExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minArrive = int.Parse(Console.ReadLine());

            int minsExam = hourOfExam * 60 + minOfExam;
            int minsArrive = hourArrive * 60 + minArrive;
            int timeMin = minsArrive - minsExam;

            if (timeMin == 0)
            {
                Console.WriteLine("On time");
            }
            else if (timeMin > 0)
            {
                Console.WriteLine("Late");

                if (timeMin < 60)
                {
                    Console.WriteLine($"{timeMin} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{timeMin / 60}:{timeMin % 60:d2} hours after the start");
                }
            }
            else
            {
                timeMin = Math.Abs(timeMin);

                if(timeMin <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{timeMin} minutes before the start");
                }
                else
                {
                    if (timeMin < 60)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{timeMin} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{timeMin / 60}:{timeMin % 60:d2} hours before the start");
                    }
                }
            }
        }
    }
}
