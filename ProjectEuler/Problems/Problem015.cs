#region Using Directives

using System;

#endregion

namespace Project.Euler.Problems
{
    public class Problem015 : IProblem
    {
        public int ProblemNumber
        {
            get { return ; }
        }

        public string Description
        {
            get { return ""; }
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
