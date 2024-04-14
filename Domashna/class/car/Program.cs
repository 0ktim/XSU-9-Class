namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car = new car();
            Console.Write("Въведете марка на автомобила:");
            car.brand = Console.ReadLine();
            Console.Write("Въведете модел на автомобила:");
            car.model = Console.ReadLine();
            Console.Write("Въведете година на производство: ");
            car.lunch = int.Parse(Console.ReadLine());
            car.allinformationforcar();
        }
    }
}