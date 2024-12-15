namespace _05.Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine($"-----Give information about your car-----");
            Console.WriteLine(" ");
            Console.Write($"Type the brand of the car: ");
            car.brand = Console.ReadLine();
            Console.Write($"Type the model of the car: ");
            car.model = Console.ReadLine();
            Console.Write($"Type the year of manifacture: ");
            car.year = int.Parse(Console.ReadLine());

            car.CarInformation();
        }
    }
}
