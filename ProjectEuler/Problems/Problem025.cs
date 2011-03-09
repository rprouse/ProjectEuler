#region Using Directives

using System;

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
            return 0;
        }
    }
}