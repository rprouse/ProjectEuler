#region Using Directives

using System;
using System.Collections.Generic;
using Project.Euler.Math;

#endregion

namespace Project.Euler.Problems
{
    public class Problem035 : IProblem
    {
        public int ProblemNumber
        {
            get { return 35; }
        }

        public string Description
        {
            get { return "How many circular primes are there below one million?"; }
        }

        public override string ToString()
        {
            return String.Format( "Problem {0:000}", ProblemNumber );
        }

        public long Solve()
        {
            List<uint> primes = new List<uint>( Primes.GetPrimes( 1000000 ) );
            List<uint> circular = new List<uint>();

            foreach ( uint prime in primes )
            {
                if ( prime < 10 )
                {
                    circular.Add( prime );
                    continue;
                }

                if ( circular.Contains( prime ) )
                    continue;

                var digits = Utility.GetDigits( prime );

                // A circular prime with at least two digits can only consist of combinations of the digits 
                // 1, 3, 7 or 9, because having 0, 2, 4, 6 or 8 as the last digit makes the number divisible 
                // by 2, and having 0 or 5 as the last digit makes it divisible by 5.
                bool skip = false;
                foreach ( uint digit in digits )
                {
                    if ( digit != 1 && digit != 3 && digit != 7 && digit != 9 )
                    {
                        skip = true;
                        break;
                    }
                }
                if ( skip ) continue;

                List<uint> candidates = new List<uint>();
                candidates.Add( prime );
                bool allFound = true;
                for ( int i = 1; i < digits.Count; i++ )
                {
                    uint candidate = 0;
                    for ( int j = digits.Count - 1; j >= 0; j-- )
                    {
                        candidate += digits[(i + j) % digits.Count];
                        if ( j > 0 )
                            candidate *= 10;
                    }
                    if ( !primes.Contains( candidate ) )
                    {
                        allFound = false;
                        break;
                    }
                    if ( !candidates.Contains( candidate ) )
                        candidates.Add( candidate );
                }
                if ( allFound )
                    circular.AddRange( candidates );
            }
            return circular.Count;
        }
    }
}
