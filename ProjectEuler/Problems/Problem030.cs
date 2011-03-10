#region Using Directives

using System;
using System.Linq;
using Project.Euler.Math;

#endregion

namespace Project.Euler.Problems
{
    public class Problem030 : IProblem
    {
        private double[] _powers = new double[10];

        public int ProblemNumber
        {
            get { return 30; }
        }

        public string Description
        {
            get { return "Find the sum of all the numbers that can be written as the sum of fifth powers of their digits."; }
        }

        public override string ToString()
        {
            return String.Format("Problem {0:000}", ProblemNumber);
        }

        public long Solve()
        {
            // Cache the powers
            for (int i = 0; i <= 9; i++)
            {
                _powers[i] = System.Math.Pow(i, 5);
            }
            long count = 0;
            for ( uint i = 32; i < 999999; i++ )
            {
                if ( IsSumOfFifths( i ) )
                    count += i;
            }
            return count;
        }

        private bool IsSumOfFifths( uint i )
        {
            return Utility.GetDigits( i ).Sum( digit => _powers[digit] ) == i;
        }
    }
}
