#region Using Directives

using System;
using System.Numerics;
using Project.Euler.Math;

#endregion

namespace Project.Euler.Problems
{
    public class Problem025 : IProblem
    {
        public int ProblemNumber
        {
            get { return 25; }
        }

        public string Description
        {
            get { return "What is the first term in the Fibonacci sequence to contain 1000 digits?"; }
        }

        public override string ToString()
        {
            return String.Format("Problem {0:000}", ProblemNumber);
        }

        public long Solve()
        {
            long count = 0;
            foreach ( BigInteger i in Fibonacci.Values )
            {
                count++;
                if ( i.ToString().Length >= 1000 )
                    break;
            }
            return count;
        }
    }
}