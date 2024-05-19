using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class Movie
    {
        public string Title { get; set; }
        public string director { get; set; }
        public int dateoflunch { get; set; }

        public Movie(string Title, string director, int dateoflunch)
        {
            this.Title = Title;
            this.director = director;
            this.dateoflunch = dateoflunch;
            agefilter();
            void agefilter() 
            {
                while (dateoflunch > 2010) {
                    Console.WriteLine(Title);break;


                }

            }

        }
    }
}
