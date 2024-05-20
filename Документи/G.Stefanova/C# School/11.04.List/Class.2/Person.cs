using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Class._2
{
    internal class Person
    {
        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public void PersonalInformation()
        {
            Console.WriteLine($"Your name is {name}, you are {age} years old and you are {sex}.");
        }
    }
}
