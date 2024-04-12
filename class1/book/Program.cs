namespace book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            classBook book = new classBook();
            book.title = Console.ReadLine();
            book.author = Console.ReadLine();
            book.year = int.Parse(Console.ReadLine());

        }
    }
}
