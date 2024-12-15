namespace _02.Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie { Title = "Something Borrowed", Director = "Luke Greenfield", Year = 2011 });
            movies.Add(new Movie { Title = "Thor", Director = "Kenneth Branagh", Year = 2011 });
            movies.Add(new Movie { Title = "The ideas of March", Director = "George Clooney", Year = 2011 });
            movies.Add(new Movie { Title = "Avatar", Director = "James Cameron", Year = 2009 });
            movies.Add(new Movie { Title = "The Dark Knight", Director = "Christopher Nolan", Year = 2008 });
            movies.Add(new Movie { Title = "Sherlock Holmes: A Game of Shadows", Director = "Guy Ritchie", Year = 2011 });
            movies.Add(new Movie { Title = "Contangion", Director = "Steven Soderbergh", Year = 2011 });
            movies.Add(new Movie { Title = "One Day", Director = "Lone Scherfig", Year = 2011 });
            movies.Add(new Movie { Title = "Red Riding Hood", Director = "Catherine Hardwicke", Year = 2011 });
            movies.Add(new Movie { Title = "The Help", Director = "Tate Taylor", Year = 2011 });
            movies.Add(new Movie { Title = "The Avengers", Director = "Joss Whedonr", Year = 2012 });
            movies.Add(new Movie { Title = "Skyfall", Director = "Sam Mendes", Year = 2012 });
            movies.Add(new Movie { Title = "Frozen", Director = "Chris Buck, Jennifer Lee", Year = 2013 });
            movies.Add(new Movie { Title = "Gravity", Director = "Alfonso Cuarón", Year = 2013 });
            movies.Add(new Movie { Title = "Interstellar", Director = "Christopher Nolan", Year = 2014 });
            movies.Add(new Movie { Title = "Spotlight", Director = "Tom McCarthy", Year = 2015 });
            movies.Add(new Movie { Title = "Joker", Director = "Todd Phillips", Year = 2019 });
            movies.Add(new Movie { Title = "Tenet", Director = " Christopher Nolan", Year = 2020 });
            movies.Add(new Movie { Title = "No Time to Die", Director = "Cary Joji Fukunaga", Year = 2021 });
            movies.Add(new Movie { Title = "Everything Everywhere All at Once", Director = "Daniel Kwan, Daniel Scheiner", Year = 2022 });

            FilterMovies(movies);
        }

        static void FilterMovies(List<Movie> movies)
        {
            Console.WriteLine($"Movies after 2010: ");
            foreach (var movie in movies)
            {
                if (movie.Year > 2010)
                {
                    Console.WriteLine($"'{movie.Title}' - {movie.Director}: {movie.Year}.");
                }
            }
        }
    }
}
