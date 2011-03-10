#region Using Directives

using System;

#endregion

namespace Project.Euler.Problems
{
    public class Problem015 : IProblem
    {
        public int ProblemNumber
        {
            get { return 15; }
        }

        public string Description
        {
            get { return "Starting in the top left corner in a 20 by 20 grid, how many routes are there to the bottom right corner?"; }
        }

        public override string ToString()
        {
            return String.Format("Problem {0:000}", ProblemNumber);
        }

        // Pascal's triangle
        // n --> #
        // 2 --> 6
        // 3 --> 20
        // 4 --> 70
        // 5 --> 252
        public long Solve()
        {
            return 0;
        }
    }
}
