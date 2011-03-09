#region Using Directives

using System;
using System.Linq;
using System.Numerics;
using Project.Euler.Math;

#endregion

namespace Project.Euler.Problems
{
    public class Problem020 : IProblem
    {
        public int ProblemNumber
        {
            get { return 20; }
        }

        public string Description
        {
            get { return "Find the sum of the digits in the number 100!"; }
        }

        public override string ToString()
        {
            return String.Format( "Problem {0:000}", ProblemNumber );
        }

        public long Solve()
        {
            var number = new BigInteger( 1 );
            for ( int i = 2; i <= 100; i++ )
            {
                number *= i;
            }
            string str = number.ToString();
            return Utility.Sum(str);
        }
    }
}
