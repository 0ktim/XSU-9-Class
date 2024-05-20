using System.Threading.Channels;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item inventory = new Item("Apple", 0.5m, 100);
            inventory.Structure();
            inventory.ListItems();
            Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine("Updated Items:");
            inventory.UpdateItem("Apple", 0.55m, 120);
            inventory.UpdateItem("Watermelon", 0.35m, 135);
            Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine("Removed Items:");
            inventory.RemoveItem("Banana");
            inventory.RemoveItem("Dragonfruit");
            Thread.Sleep(10000);
            Console.Clear();
            inventory.ListItem();
        }
    }
}
