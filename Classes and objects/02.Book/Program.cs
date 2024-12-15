namespace _02.BookClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine($"-----Give information about book-----");
            Console.WriteLine(" ");
            Console.Write("Type the title of the book: ");
            book.title = Console.ReadLine();
            Console.Write("Type the autor: ");
            book.autor = Console.ReadLine();
            Console.Write("Type the year of publishing: ");
            book.year = int.Parse(Console.ReadLine());
            Console.Clear();

            book.InformationForBook();
        }
    }
}
