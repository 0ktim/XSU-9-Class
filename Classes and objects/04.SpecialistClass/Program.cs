namespace _04.SpecialistClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Specialist specialist = new Specialist();
            Console.WriteLine($"-----Give information about your job-----");
            Console.WriteLine(" ");
            Console.Write("Type your name: ");
            specialist.name = Console.ReadLine();
            Console.Write("Type your salary: ");
            specialist.salary = double.Parse(Console.ReadLine());
            Console.Write("Type your section: ");
            specialist.section = Console.ReadLine();

            specialist.Information();
        }
    }
}
