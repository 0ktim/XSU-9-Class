using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }


        public void Filter() 
        {
        if (Age == 25) 
            {
                Console.WriteLine("Alice");
            }
        else 
            {
                Console.WriteLine("Me");
            }
        }
    }
}
