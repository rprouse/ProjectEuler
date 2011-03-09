using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Euler.Math
{
    public static class Utility
    {
        public static long Sum( string number )
        {
            return number.Where(c => c > '0' && c <= '9').Sum(c => (long) (c - '0'));
        }
    }
}
