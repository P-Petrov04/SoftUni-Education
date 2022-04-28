using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();
            int countStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countStudents; i++)
            {
                string[] studentArgs = Console.ReadLine().Split();
                string firstName = studentArgs[0];
                string lastName = studentArgs[1];
                double grade = double.Parse(studentArgs[2]);

                Student newStudent = new Student(firstName, lastName, grade);
                allStudents.Add(newStudent);
            }

            List<Student> orderedStudents = allStudents.OrderByDescending(s => s.Grade).ToList();
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
