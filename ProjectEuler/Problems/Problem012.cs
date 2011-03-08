using System;
using System.Collections.Generic;
using System.Linq;
using Project.Euler.Math;

namespace Project.Euler.Problems
{
   // -----------------------------------------------------------------------------------------------------------------------------
   // HINTS
   // -----------------------------------------------------------------------------------------------------------------------------
   // Let's say you have the primefactorisation of a number:
   //
   // 120 = 2^3 * 3^1 * 5^1
   //
   // Then you can find the number of divisors of 120 by realizing that you can select a 2 {0,1,2,3} times, a 3 {0,1} times, etc:
   // so 120 has 4 * 2 * 2 = 16 different divisors.
   // -----------------------------------------------------------------------------------------------------------------------------
   // Does this help?
   // 1+2+3=6=3*2=(3*4)/2
   // 1+2+3+4=10=2*5=(4*5)/2
   // 1+2+3+4+5=15=3*5=(5*6)/2
   // 1+2+3+4+5+6=21=3*7=(6*7)/2
   // -----------------------------------------------------------------------------------------------------------------------------
   // Therefore, the n-th triangular number can be defined as (n^2 + n) / 2 or n*(n+1)/2
   // -----------------------------------------------------------------------------------------------------------------------------
   public class Problem012 : IProblem
   {
      public int ProblemNumber
      {
         get { return 12; }
      }

      public string Description
      {
         get { return "What is the value of the first triangle number to have over five hundred divisors?"; }
      }

      public override string ToString()
      {
         return String.Format( "Problem {0:000}", ProblemNumber );
      }

      public long Solve()
      {
         uint count = 1;
         while( true )
         {
            uint triangleNumber = count*(count + 1)/2;
            uint n = Divisors.NumberOfDivisors(triangleNumber);
            if ( n > 500 )
               return triangleNumber;
            count++;
         }
      }

      private IEnumerable<uint> TriangleNumbers
      {
         get
         {
            uint i = 1;
            uint value = i;
            yield return value;
            while ( true )
            {
               i++;
               value += i;
               yield return value;
            }
         }
      }
   }
}
