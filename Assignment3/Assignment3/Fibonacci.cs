using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Fibonacci
    {
        public static int FibonacciValue(int x)
        {
            if(x == 1 || x == 2)
            {
                return 1;
            }
            int i = 1, j = 1, k = 0;
            for(int y = 3; y <= x; y++)
            {
                k = i + j;
                i = j;
                j = k;
            }
            return k;
        }
    }
}
