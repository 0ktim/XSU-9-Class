using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    internal class car
    {
        public string brand;
        public string model;
        public int lunch;

        public void allinformationforcar() {
            Console.WriteLine($"Колата {brand} {model} е произведена през {lunch}.");

        }
    }
}
