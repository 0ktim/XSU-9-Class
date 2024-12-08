using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    internal class number
    {
        public int findMax(int numBox1 , int numBox2) 
        {
        if (numBox1 > numBox2)
            {
                return numBox1;
            }
        else 
            {
                return numBox2;
            }

        }
    }
}
