using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        public string title;
        public string author;
        public int lunch;
        public void allforbook() {
            Console.WriteLine($" Книга със заглавие {title} и автор {author} e издадена през {lunch} година.   ");
        }
    }
}
