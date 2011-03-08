#region Using Directives

using System;

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
         return String.Format("Problem {0:000}", ProblemNumber);
      }

      public long Solve()
      {
         ulong number = 1;
         checked
         {
            for (int i = 2; i <= 100; i++)
            {
               try
               {
                  number *= (ulong)i;
               }
               catch (Exception e)
               {
                  break;
               }
            }
         }
         return (long)number;

      }
   }
}
