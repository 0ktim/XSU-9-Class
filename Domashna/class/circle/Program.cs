namespace circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circle circle = new circle();
            Console.Write("Въведете радиуса на кръга:");
            circle.Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на кръга е:");
            Console.WriteLine(circle.perimeter());
            Console.WriteLine("Обиколката на кръга е:");
            Console.WriteLine(circle.area()); 

        }
    }
}