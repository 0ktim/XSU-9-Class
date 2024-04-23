using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEx2
{
    internal class BookClass
    {
        public string TitleOfTheBook { get; set; }
        public string AuthorOfTheBook { get; set; }
        public double AgeOfIzdavane { get; set; }
        //Забравих как е издаване на Английски :)
        public void Combined()
        {
            Console.WriteLine($"Името на книгата е: {TitleOfTheBook}, Автора и е: {AuthorOfTheBook}, и е издадена през: {AgeOfIzdavane} година.");
        }
    }
}