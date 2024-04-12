using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    internal class human
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }

        public void AllInOne()
        {
            Console.WriteLine($"Име: {Name}. Години: {Age}. Пол: {Sex}");
        }
    }
}
