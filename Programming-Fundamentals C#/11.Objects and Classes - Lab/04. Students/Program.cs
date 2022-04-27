using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] studentArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentArgs[0];
                string lastName = studentArgs[1];
                int age = int.Parse(studentArgs[2]);
                string homeTown = studentArgs[3];

                Student newStudent = new Student(firstName, lastName, age, homeTown);
                students.Add(newStudent);

                input = Console.ReadLine();
            }

            string town = Console.ReadLine();
            List<Student> studentToPrint = students.Where(s => s.HomeTown == town).ToList();
            foreach (Student student in studentToPrint)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
