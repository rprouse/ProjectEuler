using System.Collections.Generic;

namespace Project.Euler.Math
{
   public static class Primes
   {
      private static IList<uint> _found = new List<uint>();

      static Primes()
      {
         _found.Add(2);
         _found.Add(3);
      }

      /// <summary>
      /// Gets the prime numbers from 2 up to and including max. This method caches primes it has already calculated.
      /// </summary>
      /// <param name="max">The max</param>
      /// <returns></returns>
      public static IEnumerable<uint> GetPrimes( uint max )
      {
         uint candidate = 3;
         // First return the primes we have cached
         foreach (uint p in _found)
         {
            candidate = p + 2;
            yield return p;
         }

         while ( candidate <= max )
         {
            bool isPrime = true;
            foreach ( uint prime in _found )
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
               _found.Add( candidate );
               yield return candidate;
            }
            candidate += 2;
         }
      }
   }
}
