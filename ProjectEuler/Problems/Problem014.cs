#region Using Directives

using System;

#endregion

namespace Project.Euler.Problems
{
   public class Problem014 : IProblem
   {
      public int ProblemNumber
      {
         get { return 14; }
      }

      public string Description
      {
         get { return "Find the longest sequence using a starting number under one million."; }
      }

      public override string ToString()
      {
         return String.Format("Problem {0:000}", ProblemNumber);
      }

      public long Solve()
      {
         long maxCount = 0;
         long maxNumber = 0;
         for ( long number = 1; number < 1000000; number++ )
         {
            long count = ChainLength(number);
            if ( count > maxCount )
            {
               maxCount = count;
               maxNumber = number;
            }
         }
         return maxNumber;
      }

      private long ChainLength( long n )
      {
         long count = 1;
         while ( n > 1 )
         {
            if (n%2 == 0)
               n /= 2;
            else
               n = 3*n + 1;
            count++;
         }
         return count;
      }
   }
}
