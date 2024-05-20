namespace _03.Inventar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();

            List<Item> items = new List<Item>();
            items.Add(new Item { Name = "Phone", Price = 1026.30 , Quantity = 1});
            items.Add(new Item { Name = "Headphones", Price = 340.60 , Quantity = 1});
            items.Add(new Item { Name = "Laptop", Price = 1280.10 , Quantity = 1});
            items.Add(new Item { Name = "Computer", Price = 1526.80 , Quantity = 2});
            items.Add(new Item { Name = "Sandwiches", Price = 2.20 , Quantity = 6});
            items.Add(new Item { Name = "Coca Cola", Price = 1.80 , Quantity = 4});
            items.Add(new Item { Name = "Chips", Price = 3.30 , Quantity = 1});
            items.Add(new Item { Name = "Juice", Price = 1.10 , Quantity = 5});
            
        }
    }
}
