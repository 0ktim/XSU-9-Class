namespace circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            classCircle circle = new classCircle();
            circle.Radius = double.Parse(Console.ReadLine());
            circle.AllInOne();

        }
    }
}
