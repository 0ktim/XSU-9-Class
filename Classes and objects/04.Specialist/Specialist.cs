using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SpecialistClass
{
    internal class Specialist
    {
        public string name { get; set; }
        public double salary { get; set; }
        public string section { get; set; }

        public void Information()
        {
            Console.WriteLine($"Your salary is {salary} and your section is {section}.");
        }
    }
}
