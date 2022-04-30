using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Family
    {
        public Family()
        {
            this.AllPersons = new List<Person>();
        }
        public List<Person> AllPersons { get; set; }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] personArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                Person newMember = new Person(name, age);
                family.AllPersons.Add(newMember);
            }

                Person oldestPerson = family.AllPersons.OrderByDescending(p => p.Age).FirstOrDefault();
                Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
