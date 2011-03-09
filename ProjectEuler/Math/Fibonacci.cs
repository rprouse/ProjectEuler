using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Project.Euler.Math
{
    public static class Fibonacci
    {
        public static IEnumerable<BigInteger> Values
        {
            get 
            { 
                BigInteger first = 1;
                BigInteger second = 1;
                yield return first;
                yield return second;
                while ( true )
                {
                    BigInteger third = first + second;
                    yield return third;
                    first = second;
                    second = third;
                }
            }
        }
    }
}
