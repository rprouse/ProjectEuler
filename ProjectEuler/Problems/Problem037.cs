#region Using Directives

using System;
using System.Collections.Generic;
using Project.Euler.Math;

#endregion

namespace Project.Euler.Problems
{
    public class Problem037 : IProblem
    {
        public int ProblemNumber
        {
            get { return 37; }
        }

        public string Description
        {
            get { return "Find the sum of all eleven primes that are both truncatable from left to right and right to left."; }
        }

        public override string ToString()
        {
            return String.Format("Problem {0:000}", ProblemNumber);
        }

        public long Solve()
        {
            int count = 0;
            long sum = 0;

            List<uint> primes = new List<uint>( Primes.GetPrimes( 1000000 ) );

            foreach ( uint prime in primes )
            {
                if (prime < 10)
                {
                    continue;
                }

                bool skip = false;

                var digits = Utility.GetDigits( prime );

                // Can only consist of combinations of the digits 
                // 1, 3, 7 or 9, because having 0, 2, 4, 6 or 8 as the last digit makes the number divisible 
                // by 2, and having 0 or 5 as the last digit makes it divisible by 5.
                foreach ( uint digit in digits )
                {
                    if ( digit != 1 && digit != 3 && digit != 7 && digit != 9 )
                    {
                        skip = true;
                        break;
                    }
                }
                if ( skip ) continue;

                // Truncate left
                uint l = Utility.TruncateLeft( prime );
                while( !skip && l > 0 )
                {
                    if ( !primes.Contains( l ) )
                    {
                        skip = true;
                    }
                    l = Utility.TruncateLeft( l );
                }

                // Truncate right
                uint r = Utility.TruncateRight(prime);
                while ( !skip && r > 0 )
                {
                    if ( !primes.Contains(r) )
                    {
                        skip = true;
                    }
                    r = Utility.TruncateRight(r);
                }

                if ( !skip )
                {
                    count++;
                    sum += prime;
                }

                if ( count == 11 )
                    break;
            }
            return sum;
        }
    }
}
