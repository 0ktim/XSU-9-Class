namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            human people = new human();
            Console.Write("Името Ви е: ");
            people.Name = Console.ReadLine();
            Console.Write("Годините Ви са: ");
            people.Age = int.Parse(Console.ReadLine());
            Console.Write("Полът Ви е: ");
            people.Sex = Console.ReadLine();
            people.AllInOne();
        }
    }
}
