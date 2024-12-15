﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CircleClass
{
    internal class Circle
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Math.Sqrt(Radius);
        }

        public double CalculatePerimeter()
        {
            return Math.PI * 2 * Radius;
        }
    }
}
