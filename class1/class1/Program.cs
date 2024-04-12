namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            human people = new human();
            Console.Write("Името Ви е: ");
            people.Name = Console.ReadLine();
            people.Age = int.Parse(Console.ReadLine());
            people.Sex = Console.ReadLine();
            people.AllInOne();
        }
    }
}
