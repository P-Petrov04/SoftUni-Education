using System;

namespace _3._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int persons = int.Parse(Console.ReadLine());

            int courses = capacity / persons;
            int peopleLeft = capacity % persons;
            if (peopleLeft != 0)
            {
                courses++;
            }
            Console.WriteLine(courses);

  

          

        }
    }
}
