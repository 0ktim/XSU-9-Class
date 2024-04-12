using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BookClass
{
    internal class Book
    {
        public string title { get; set; }
        public string autor { get; set; }
        public int year { get; set; }

        public void InformationForBook()
        {
            Console.WriteLine($"The book is {title} which autor is {autor} and the year of publishing is {year}.");
        }

    }
}
