using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Item
    {
        public Item(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public List<Item> items = new List<Item>();
        public void AddItem(string name, decimal price, int quantity)
        {
            items.Add(new Item(name, price, quantity));
            Console.WriteLine($"Item {name} added.");
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void RemoveItem(string name)
        {
            items.RemoveAll(v => v.Name == name);
            Console.WriteLine($"Item {name} removed.");
        }
        public void UpdateItem(string name, decimal price, int quantity)
        {
            foreach (var item in items)
            {
                if (item.Name == name)
                {
                    item.Price = price;
                    item.Quantity = quantity;
                    Console.WriteLine($"Item {name} updated.");
                    return;
                }
            }
            Console.WriteLine($"Item {name} not found.");
        }
        public void ListItems()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price:C}, Quantity: {item.Quantity}");
            }
        }
        public void ListItem() 
        {
            Console.WriteLine("Updated Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price:C}, Quantity: {item.Quantity}");
            }
        }
        public void Structure() 
        {
            int[] times = new int[10];
            string AddMore = "";
            for (int i = 0; i < times.Length; i++)
            {
                AddMore = Console.ReadLine();
                switch (AddMore)
                {
                    case "Apple":
                        AddItem("Apple", 0.5m, 100);
                        break;
                    case "Banana":
                        AddItem("Banana", 0.2m, 150);
                        break;
                    case "Grapes":
                        AddItem("Grapes", 0.9m, 80);
                        break;
                    case "Orange":
                        AddItem("Orange", 0.25m, 145);
                        break;
                    case "Mango":
                        AddItem("Mango", 1.9m, 30);
                        break;
                    case "Kiwi":
                        AddItem("Kiwi", 1m, 60);
                        break;
                    case "Dragonfruit":
                        AddItem("Dragonfruit", 5m, 1);
                        break;
                    case "Pineapple":
                        AddItem("Pineapple", 3m, 3);
                        break;
                    case "Papaya":
                        AddItem("Papaya", 2.5m, 5);
                        break;
                    case "Watermelon":
                        AddItem("Watermelon", 0.30m, 140);
                        break;
                    default:
                        Console.WriteLine("Invalid fruit!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            }
        }


        

    }
}
