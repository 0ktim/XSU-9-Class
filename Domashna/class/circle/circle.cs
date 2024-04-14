using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    internal class circle
    {
        public double Radius { get; set; }
        public double perimeter() {
            return 2 * Radius * Radius;
        }
        public double area() {
        return Math.PI * Radius * Radius;
        }
    }
}
