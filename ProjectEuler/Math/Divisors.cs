using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Euler.Math
{
   public static class Divisors
   {
      public static uint NumberOfDivisors( uint n )
      {
         Dictionary<uint, uint> array = new Dictionary<uint, uint>();
         foreach (uint prime in Primes.GetPrimes(n))
         {
            while ( n % prime == 0 )
            {
               n /= prime;
               if ( array.ContainsKey( prime ) )
                  array[prime]++;
               else
                  array[prime] = 1;
            }
            if ( n == 1 )
               break;
         }

         uint count = 1;
         foreach (uint key in array.Keys)
         {
            count *= ( array[key] + 1 );
         }
         return count;
      }

      public static IList<uint> AllDivisors( uint n )
      {
         List<uint> primeDivisors = new List<uint>( PrimeDivisors( n ) );

         List<uint> divisors = new List<uint>( primeDivisors );
         List<uint> found = new List<uint>();
         do
         {
            found.Clear();
            foreach ( uint prime in primeDivisors )
            {
               foreach ( uint divisor in divisors )
               {
                  uint candidate = prime * divisor;
                  if ( candidate < n && n % candidate == 0 && !found.Contains( candidate ) && !divisors.Contains( candidate ) )
                  {
                     found.Add( candidate );
                  }
               }
            }
            divisors.AddRange( found );
         } while ( found.Count > 0 );
         divisors.Add( 1U );
         if ( !divisors.Contains( n ) )
            divisors.Add( n );
         divisors.Sort();
         return divisors;
      }

      /// <summary>
      /// Gets the prime divisors for a given number
      /// </summary>
      /// <param name="n">The n.</param>
      /// <returns></returns>
      public static IEnumerable<uint> PrimeDivisors( uint n )
      {
         return Primes.GetPrimes( n ).Where( prime => n % prime == 0 );
      }
   }
}
