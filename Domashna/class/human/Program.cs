namespace human
{
    internal class Program
    {
        static void Main(string[] args)
        {
            human human = new human();
            Console.Write("Въведете име:");
            human.Name = Console.ReadLine();
            Console.Write("Въведете години:");
            human.Age = int.Parse(Console.ReadLine());
            Console.Write("Въдете пол:");
            human.Pol = Console.ReadLine();
            human.informationforhuman();

        }
    }
}