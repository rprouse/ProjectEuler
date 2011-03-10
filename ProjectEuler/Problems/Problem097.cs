#region Using Directives

using System;
using System.Numerics;
using Project.Euler.Math;

#endregion

namespace Project.Euler.Problems
{
    public class Problem097 : IProblem
    {
        public int ProblemNumber
        {
            get { return 97; }
        }

        public string Description
        {
            get { return "Find the last ten digits of the non-Mersenne prime: 28433 × 2^7830457 + 1."; }
        }

        public override string ToString()
        {
            return String.Format("Problem {0:000}", ProblemNumber);
        }

        public long Solve()
        {
            checked
            {
                long i = 2;
                for ( int j = 1; j < 7830457; j++ )
                {
                    i *= 2;
                    // Truncate
                    i %= 10000000000;
                }
                i *= 28433;
                i++;
                return i % 10000000000;
            }
        }
    }
}
