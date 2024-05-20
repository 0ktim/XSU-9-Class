using _02.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Movies
{
    internal class Movie
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }

        public static void Movies()
        {
            Movie movie = new Movie();
            List<Movie> movies = new List<Movie>();
            //18 Movies
            movies.Add(new Movie { Name = "Something Borrowed", Director = "Luke Greenfield", Year = 2011 });
            movies.Add(new Movie { Name = "Thor", Director = "Kenneth Branagh", Year = 2011 });
            movies.Add(new Movie { Name = "The ideas of March", Director = "George Clooney", Year = 2011 });
            movies.Add(new Movie { Name = "Sherlock Holmes: A Game of Shadows", Director = "Guy Ritchie", Year = 2011 });
            movies.Add(new Movie { Name = "Contangion", Director = "Steven Soderbergh", Year = 2011 });
            movies.Add(new Movie { Name = "One Day", Director = "Lone Scherfig", Year = 2011 });
            movies.Add(new Movie { Name = "Red Riding Hood", Director = "Catherine Hardwicke", Year = 2011 });
            movies.Add(new Movie { Name = "The Help", Director = "Tate Taylor", Year = 2011 });
            movies.Add(new Movie { Name = "The Avengers", Director = "Joss Whedonr", Year = 2012 });
            movies.Add(new Movie { Name = "Skyfall", Director = "Sam Mendes", Year = 2012 });
            movies.Add(new Movie { Name = "Frozen", Director = "Chris Buck, Jennifer Lee", Year = 2013 });
            movies.Add(new Movie { Name = "Gravity", Director = "Alfonso Cuarón", Year = 2013 });
            movies.Add(new Movie { Name = "Interstellar", Director = "Christopher Nolan", Year = 2014 });
            movies.Add(new Movie { Name = "Spotlight", Director = "Tom McCarthy", Year = 2015 });
            movies.Add(new Movie { Name = "Joker", Director = "Todd Phillips", Year = 2019 });
            movies.Add(new Movie { Name = "Tenet", Director = " Christopher Nolan", Year = 2020 });
            movies.Add(new Movie { Name = "No Time to Die", Director = "Cary Joji Fukunaga", Year = 2021 });
            movies.Add(new Movie { Name = "Everything Everywhere All at Once", Director = "Daniel Kwan, Daniel Scheiner", Year = 2022 });

            foreach (var movieAfter2010 in movies)
            {
                Console.WriteLine($"Филм - {movie.Name}. Режисьор - {movie.Director}. Година на издаване - {movie.Year}.");
            }
        }
    }
}
