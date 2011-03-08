using System;

namespace Project.Euler.Problems
{
   public class ProblemAnswer
   {
      public ProblemAnswer( long answer, TimeSpan elapsed )
      {
         Answer = answer;
         Elapsed = elapsed;
      }

      public long Answer { get; private set; }
      public TimeSpan Elapsed { get; private set; }
   }
}
