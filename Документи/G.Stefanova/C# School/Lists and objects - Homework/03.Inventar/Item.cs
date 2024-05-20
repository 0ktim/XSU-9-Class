using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Inventar
{
    internal class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
       
        public void AddItem()
        {
            Console.WriteLine("What item do you want to add:" +
            "Phone, Juice, Headphones, Chips, Coca cola, Computer, Laptop, Sandwiches? ");
            Name = Console.ReadLine();
            Quantity = int.Parse(Console.ReadLine());
        }

        public void RemoveItem()
        {
            string answer = string.Empty;
            Console.WriteLine("Искате ли да премахнете някой елемент");
            if (answer == "Yes" || answer == "yes")
            {
                Console.WriteLine("Кой елемент искате да премахнете?");
                Name = Console.ReadLine();
                if (Name == "")
                {

                }
            }
            else if (answer == "No" || answer == "no")
            {
                Console.WriteLine("Всички елементи остават в инвентара.");
            }

        }
    }
}
