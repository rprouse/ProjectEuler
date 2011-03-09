#region Using Directives

using System;

#endregion

namespace Project.Euler.Problems
{
    public class Problem019 : IProblem
    {
        public int ProblemNumber
        {
            get { return 19; }
        }

        public string Description
        {
            get { return "How many Sundays fell on the first of the month during the twentieth century?"; }
        }

        public override string ToString()
        {
            return String.Format("Problem {0:000}", ProblemNumber);
        }

        // 1 Jan 1900 was a Monday.
        // Thirty days has September,
        // April, June and November.
        // All the rest have thirty-one,
        // Saving February alone,
        // Which has twenty-eight, rain or shine.
        // And on leap years, twenty-nine.
        // A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
        //
        // 1 Jan 1901 to 31 Dec 2000
        public long Solve()
        {
            long count = 0;
            for (int year = 1901; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    DateTime candidate = new DateTime( year, month, 1 );
                    if ( candidate.DayOfWeek == DayOfWeek.Sunday )
                        count++;
                }
            }
            return count;
        }
    }
}
