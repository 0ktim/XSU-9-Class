namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> list = new List<Movie>();
            list.Add(new Movie("Fast and Furison 1", "Роб Коен", 2001));
            list.Add(new Movie("Fast and Furison 2","Джон Сингълтън",2003));
            list.Add(new Movie("Fast and Furison 3", "Джъстин Лин", 2006));
            list.Add(new Movie("Fast and Furison 4", "Джъстин Лин", 2009));
            list.Add(new Movie("Fast and Furison 5", "Джъстин Лин", 2011));
            list.Add(new Movie("Fast and Furison 6", "Джъстин Лин", 2013));
            list.Add(new Movie("Fast and Furison 7", "Джеймс Уан", 2015));
            list.Add(new Movie("Fast and Furison 8", "Феликс Гари Грей", 2017));
            list.Add(new Movie("Fast and Furison 9", "Джъстин Лин", 2021));
            list.Add(new Movie("Fast and Furison 10", "Луи Льотерие", 2023));


        }
    }
}