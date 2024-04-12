namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clssCars cars = new clssCars();

            Console.Write("Марката на автомобила е: ");
            cars.mark = Console.ReadLine();

            Console.Write("Модела на автомобила е: ");
            cars.model = Console.ReadLine();

            Console.Write("Автомобила е произведен през: ");
            cars.year = int.Parse(Console.ReadLine());

            cars.AllInOne();
        }
    }
}
