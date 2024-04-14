using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace human
{
    internal class human
    {
         public string Name { get; set; }
         public int Age { get; set; }
         public string Pol;
        public void informationforhuman() {
            Console.WriteLine($"Човек със име {Name} на {Age} години и пол {Pol}");
        }
    }
}
