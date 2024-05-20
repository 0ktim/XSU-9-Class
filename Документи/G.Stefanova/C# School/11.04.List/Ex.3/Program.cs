namespace Ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.Write("Type radius: ");
            circle.Radius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Area: {circle.CalculateArea():f2}" +
            $" Perimeter: {circle.CalculatePerimeter():f2}");
        }
    }
}
