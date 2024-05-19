using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int YearOfIssue  { get; set; }

        public  static void Issued() 
        {
        List<Movie> movie = new List<Movie>();
        List<Movie> movies = new List<Movie>();
            movies.Add(new Movie { Title = "The Way Of Harmony", Director = "Стефан Командарев", YearOfIssue = 2001 });
            movies.Add(new Movie { Title = "Хълмът на боровинките", Director = "Александър Морфов", YearOfIssue = 2001 });
            movies.Add(new Movie { Title = "Футболни хамелеони", Director = "Стойчо Шишков", YearOfIssue = 2008 });
            movies.Add(new Movie { Title = "Нощ и ден", Director = "Красимир Крумов", YearOfIssue = 2006 });
            movies.Add(new Movie { Title = "Раци", Director = "Иван Черкелов", YearOfIssue = 2009 });
            movie.Add(new Movie { Title = "Мисия Лондон", Director = "Димитър Митовски", YearOfIssue = 2010 });
            movie.Add(new Movie { Title = "Инкогнита", Director = "Михаил Пандърски", YearOfIssue = 2012 });
            movie.Add(new Movie { Title = "6 и 1 наум", Director = "Лъчезар Петров", YearOfIssue = 2016 });
            movie.Add(new Movie { Title = "Уроци по немски", Director = "Павел Г. Веснаков", YearOfIssue = 2020 });
            movie.Add(new Movie { Title = "Случаят тесла", Director = "Андрей Хадживасилев", YearOfIssue = 2023 });
            while (true)
            {


                Console.WriteLine("Филми издадени след 2010 година:");
                Console.WriteLine();
                foreach (var move in movie)
                {
                    if (move.YearOfIssue >= 2010)
                    {
                        Console.WriteLine($" Името на филма е {move.Title} и е издаден през {move.YearOfIssue}.");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Искате ли да видите филми преди 2010?");
                Console.WriteLine();
                string change = Console.ReadLine();
                switch (change)
                {
                    case "yes":
                        Console.Clear();
                        Console.WriteLine("Филми издадени преди 2010 година:");
                        Console.WriteLine();
                        foreach (var move in movies)
                        {
                            if (move.YearOfIssue < 2010)
                            {
                                Console.WriteLine($" Името на филма е {move.Title} и е издаден през {move.YearOfIssue}.");
                            }
                        }
                        break;
                    case "no":
                        while (true)
                        {
                            break;
                           
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid command");
                        break;
                }
                Thread.Sleep(2500);
                Console.Clear();
            }
        }
    }
}
