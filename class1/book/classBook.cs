using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    internal class classBook
    {
        public string title {  get; set; }
        public string author { get; set; }
        public int year { get; set; }

        public void AllInOne() 
        {
            Console.WriteLine($"Заглавието е: {title}. Автор е: {author}. Годината на издаване е: {year}.");
        }



    }
}
