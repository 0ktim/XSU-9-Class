namespace _03.CircleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine($"-----Give information about circle-----");
            Console.WriteLine(" ");
            Console.Write("Type radius: ");
            circle.Radius = int.Parse(Console.ReadLine());

            Console.WriteLine($"The area is {circle.CalculateArea():f2} and the perimeter is {circle.CalculatePerimeter():f2}.");
        }
    }
}
