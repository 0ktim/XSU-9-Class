using System.Xml.Linq;

namespace _03.Items
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            List<Item> items = new List<Item>();
            items.Add(new Item { Name = "Phone", Price = 1026.30, Quantity = 1 });
            items.Add(new Item { Name = "Headphones", Price = 340.60, Quantity = 1 });
            items.Add(new Item { Name = "Sandwiches", Price = 2.20, Quantity = 6 });
            items.Add(new Item { Name = "Coca Cola", Price = 1.80, Quantity = 4 });
            items.Add(new Item { Name = "Chips", Price = 3.30, Quantity = 1 });
            items.Add(new Item { Name = "Juice", Price = 1.10, Quantity = 5 });

            ItemInventory(items);
            AddItem();
            RemoveItem();
            RecoverItems();
        }
        static void ItemInventory(List<Item> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Item: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}.");
            }
        }
        static void AddItem()
        {
            Console.WriteLine(" ");
            Console.WriteLine("What item do you want to add?");
            string name = Console.ReadLine();
            Console.Write("Quantity - ");
            int quantity = int.Parse(Console.ReadLine());
            if (name == "Phone" || name == "Juice" || name == "Coca Cola" || name == "Chips")
            {
                Console.WriteLine($"{name} is added. Quantity - {quantity}");
            }
            else if (name == "Sandiwches" || name == "Headphones")
            {
                Console.WriteLine($"{name} are added. Quantity - {quantity}");
            }
            else
            {
                Console.WriteLine("Invalid item!");
            }
        }
        static void RemoveItem()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Do you want to remove any item? (Type the item you want to remove!)");
            string answer = Console.ReadLine();
            if (answer == "Phone" || answer == "Juice" || answer == "Coca Cola" || answer == "Chips" || answer == "Sandiwches" || answer == "Headphones")
            {
                Console.WriteLine($"{answer} has been removed from the inventor.");
            }
            else if (answer == "No" || answer == "no")
            {
                Console.WriteLine("The items aren't removed.");
            }
            else
            {
                Console.WriteLine("Invalid answer!");
            }
        }
        static void RecoverItems()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Do you want to recover any item? (Type the item you want to recover!)");
            string answer = Console.ReadLine();
            if (answer == "Phone" || answer == "Juice" || answer == "Coca Cola" || answer == "Chips" || answer == "Sandiwches" || answer == "Headphones")
            {
                Console.WriteLine($"{answer} has been recovered from the inventor.");
            }
            else if (answer == "No" || answer == "no")
            {
                Console.WriteLine("The items aren't recovered.");
            }
            else
            {
                Console.WriteLine("Invalid answer!");
            }
        }
    }
}
