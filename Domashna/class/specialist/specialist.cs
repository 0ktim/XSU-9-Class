using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialist
{
    internal class specialist
    {
        public string name { get; set; }
        public int Salary { get; set; }
        public string otdel { get; set; }

        public void changeotdel(  ) {
            Console.WriteLine("Въведете новия отдел:");
            string newotdel = Console.ReadLine();
            string novotdel = newotdel;    
            Console.WriteLine($"{name} от отдел {novotdel} със заплата {Salary}.");


        }

        public void allinformation() {
            Console.WriteLine($"{name} от отдел {otdel} със заплата {Salary}.");
        }

        public void changesalary() {
            Console.WriteLine("Въведете нова заплата:");
            string newsalary = Console.ReadLine();
        string novtsalary = newsalary;
            Console.WriteLine($"{name} от отдел {otdel} със заплата {novtsalary}.");

        }


    }
}
