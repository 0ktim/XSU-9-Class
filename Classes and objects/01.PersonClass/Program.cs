namespace _01.PersonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine($"-----Give information about you-----");
            Console.WriteLine(" ");
            Console.Write("Type your name: ");
            person.name = Console.ReadLine();
            Console.Write("Type your sex: ");
            person.sex = Console.ReadLine();
            Console.Write("Type your age: ");
            person.age = int.Parse(Console.ReadLine());
            Console.Clear();

            person.PersonalInformation();
        }
    }
}
