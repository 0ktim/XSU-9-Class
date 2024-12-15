using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Car
{
    internal class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int year { get; set; }

        public void CarInformation()
        {
            Console.WriteLine($"The brand is {brand}, the model is {model} and the year of manifacture is {year}.");
        }
    }
}
