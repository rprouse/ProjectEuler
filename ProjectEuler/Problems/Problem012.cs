using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.Euler.Problems
{
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
         foreach (uint triangleNumber in TriangleNumbers)
         {
            uint n = NumberOfDivisors(triangleNumber);
            if ( n > 5 )
               return triangleNumber;
         }
         return 0;
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

      private uint NumberOfDivisors( uint n )
      {
         List<uint> primeDivisors = new List<uint>( PrimeDivisors( n ) );
         List<uint> divisors = new List<uint>( primeDivisors );
         bool found = true;
         while ( found )
         {
            foreach (uint p in primeDivisors)
            {

            }
         }
         return (uint)divisors.Count + 1;
      }

      private static IEnumerable<uint> PrimeDivisors( uint n )
      {
         return Primes( n ).Where(prime => n % prime == 0);
      }

      public static IEnumerable<uint> Primes( uint max )
      {
         yield return 2;
         List<uint> found = new List<uint>();
         found.Add( 3 );
         uint candidate = 3;
         while ( candidate <= max )
         {
            bool isPrime = true;
            foreach ( uint prime in found )
            {
               if ( prime * prime > candidate )
               {
                  break;
               }
               if ( candidate % prime == 0 )
               {
                  isPrime = false;
                  break;
               }
            }
            if ( isPrime )
            {
               found.Add( candidate );
               yield return candidate;
            }
            candidate += 2;
         }
      }
   }
}
