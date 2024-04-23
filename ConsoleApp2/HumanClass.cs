using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class HumanClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public void WholeHuman()
        {
            Console.WriteLine($"Името на човека е {Name}, той е на {Age} години, и е от {Gender}ки пол.");
        }
    }
}
