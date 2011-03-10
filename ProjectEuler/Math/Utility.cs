using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Euler.Math
{
    public static class Utility
    {
        /// <summary>
        /// Sums the digits of a specified number.
        /// </summary>
        /// <param name="number">The number as a string.</param>
        /// <returns></returns>
        public static long Sum( string number )
        {
            return number.Where(c => c > '0' && c <= '9').Sum(c => (long) (c - '0'));
        }

        /// <summary>
        /// Gets the digits of a given number.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public static List<uint> GetDigits( uint n )
        {
            var digits = new List<uint>();
            while ( n > 0 )
            {
                digits.Add( n % 10 );
                n = n / 10;
            }
            return digits;
        }

        /// <summary>
        /// Truncates the right digit off a number 1234 => 123.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public static uint TruncateRight( uint n )
        {
            return n/10;
        }

        /// <summary>
        /// Truncates the left digit off a number 1234 => 234
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public static uint TruncateLeft( uint n )
        {
            uint count = 1;
            uint i = n;
            while ( i > 9 )
            {
                count *= 10;
                i /= 10;
            }
            return n - (i*count);
        }
    }
}
