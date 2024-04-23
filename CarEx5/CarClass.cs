using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEx5
{
    public class CarClass
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double GodinaNaProizvodstvo { get; set; }
        public void WholeHuman()
        {
            Console.WriteLine($"Марката на колата е: {Marka}, Модела и е: {Model}, и е произведена през: {GodinaNaProizvodstvo} година.");
        }
    }
}
