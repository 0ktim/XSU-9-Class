using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CircleEx3
{
    public class CircleClass
    {
    public double Radius { get; set; }
        public CircleClass(double radius)
        {
            Radius = radius;
        }
        public double Obikolka()
        {
            return 2 * Math.PI * Radius;
        }
        public double Lice()
        {
            return Math.PI * Radius * Radius;
        }  
    }
}

