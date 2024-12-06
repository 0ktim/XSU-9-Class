using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_numbers
{
    internal class Numbers
    {
        public int FindMax(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }
    }
}
