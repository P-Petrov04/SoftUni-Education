using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    class Product
    {
        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Person
    {
        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;

            this.Bag = new List<string>();
        }
        public string Name { get; set; }
        public int Money { get; set; }
        public List<string> Bag { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPersons = new List<Person>();
            List<Product> allProductsArgs = new List<Product>();
            string[] allPeople = Console.ReadLine().Split(";");
            string[] allProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (string person in allPeople)
            {
                string[] personArgs = person.Split("=", StringSplitOptions.RemoveEmptyEntries);

                string name = personArgs[0];
                int money = int.Parse(personArgs[1]);

                Person newPerson = new Person(name, money);
                allPersons.Add(newPerson);
            }

            foreach (string product in allProducts)
            {
                string[] productArgs = product.Split("=", StringSplitOptions.RemoveEmptyEntries);

                string name = productArgs[0];
                int price = int.Parse(productArgs[1]);

                Product newProduct = new Product(name, price);
                allProductsArgs.Add(newProduct);
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = commandArgs[0];
                string productName = commandArgs[1];

                Person currentPerson = allPersons.FirstOrDefault(p => p.Name == personName);
                int currentPersonMoney = currentPerson.Money;

                Product currentProduct = allProductsArgs.FirstOrDefault(p => p.Name == productName);
                int currentProductPrice = currentProduct.Price;
                
                if (currentPersonMoney >= currentProductPrice)
                {
                    currentPerson.Bag.Add(currentProduct.Name);
                    currentPerson.Money -= currentProductPrice;
                    Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                }

                command = Console.ReadLine();
            }

            foreach (Person person in allPersons)
            {
                if (person.Bag.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag)}");
                }
            }
        }
    }
}
