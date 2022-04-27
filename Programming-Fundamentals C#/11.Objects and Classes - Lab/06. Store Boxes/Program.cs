using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Item
    {
        public Item(string itemName, decimal itemPrice)
        {
            this.Name = itemName;
            this.Price = itemPrice;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box(int serialNumber, Item item, int quantity, decimal priceOfBox)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = quantity;
            this.PriceOfBox = priceOfBox;
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceOfBox { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> allBoxes = new List<Box>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] infoArgs = input.Split();
                int serialNumber = int.Parse(infoArgs[0]);
                string itemName = infoArgs[1];
                int itemQuantity = int.Parse(infoArgs[2]);
                decimal itemPrice = decimal.Parse(infoArgs[3]);

                Item newItem = new Item(itemName, itemPrice);
                decimal boxPrice = itemPrice * itemQuantity;
                Box newBox = new Box(serialNumber, newItem, itemQuantity, boxPrice);
                allBoxes.Add(newBox);

                input = Console.ReadLine();
            }

            List<Box> orderedBoxes = allBoxes.OrderByDescending(b => b.PriceOfBox).ToList();
            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceOfBox:f2}");
            }
        }
    }
}
