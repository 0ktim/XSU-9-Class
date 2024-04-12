
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class clssCars
    {
        public string mark;

        public string model;

        public int year;

        public void AllInOne() 
        {
            Console.WriteLine($"Автомобиула е от марка {mark} с модел {model} произведен през {year}.");
        }

    }
}
