#region Using Directives

using System;
using System.Numerics;
using Project.Euler.Math;

#endregion

namespace Project.Euler.Problems
{
    public class Problem016 : IProblem
    {
        public int ProblemNumber
        {
            get { return 16; }
        }

        public string Description
        {
            get { return "What is the sum of the digits of the number 2^1000?"; }
        }

        public override string ToString()
        {
            return String.Format("Problem {0:000}", ProblemNumber);
        }

        public long Solve()
        {
            BigInteger i = BigInteger.Pow( 2, 1000 );
            return Utility.Sum(i.ToString());
        }
    }
}
