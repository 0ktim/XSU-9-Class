using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    internal class classCircle
    {
        public double Radius;

        public double KalculateArea() 
        {
            return Math.PI * Radius * Radius;
        }
        public double KalculatePerimeter() 
        {
            return 2 * Math.PI * Radius;
        }
        public void AllInOne() 
        {
            Console.WriteLine($"Площа е: {KalculateArea()} и периметъра е {KalculatePerimeter()}.");
        }
    }
}
