namespace book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            classBook book = new classBook();
            Console.Write("Заглавието на книгата е: ");
            book.title = Console.ReadLine();
            Console.Write("Автор на книгата е: ");
            book.author = Console.ReadLine();
            Console.Write("Година на издаване на книгата е: ");
            book.year = int.Parse(Console.ReadLine());
            book.AllInOne();

        }
    }
}
