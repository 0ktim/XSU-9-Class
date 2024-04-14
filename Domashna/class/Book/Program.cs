namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.Write("Въведете заглавие:");
            book.title = Console.ReadLine();
            Console.Write("Въведете автор:");
            book.author = Console.ReadLine();
            Console.Write("Въведете година на издаване:");
            book.lunch = int.Parse(Console.ReadLine());
            book.allforbook();
        }
    }
}