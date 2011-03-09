#region Using Directives

using System;
using System.Numerics;

#endregion

namespace Project.Euler.Problems
{
    public class Problem048 : IProblem
    {
        public int ProblemNumber
        {
            get { return 48; }
        }

        public string Description
        {
            get { return "Find the last ten digits of 1^1 + 2^2 + ... + 1000^1000."; }
        }

        public override string ToString()
        {
            return String.Format("Problem {0:000}", ProblemNumber);
        }

        public long Solve()
        {
            BigInteger i = 1;
            for (int j = 2; j <= 1000; j++)
            {
                i += BigInteger.Pow(j, j);
            }
            string value = i.ToString();
            string last = value.Substring(value.Length - 10);
            return long.Parse(last);
        }
    }
}