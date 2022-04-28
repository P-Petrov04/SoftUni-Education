using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPersons = new List<Person>();
            string personInfo = Console.ReadLine();
            while (personInfo != "End")
            {
                string[] personArgs = personInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personArgs[0];
                string ID = personArgs[1];
                int age = int.Parse(personArgs[2]);

                if (allPersons.Any(p => p.ID == ID))
                {
                    Person currPerson = allPersons.FirstOrDefault(p => p.ID == ID);
                    currPerson.Name = name;
                    currPerson.Age = age;
                }
                else
                {
                    Person newPerson = new Person(name, ID, age);
                    allPersons.Add(newPerson);
                }

                personInfo = Console.ReadLine();
            }

            List<Person> orderedPersons = allPersons.OrderBy(p => p.Age).ToList();
            foreach (Person person in orderedPersons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
