#region Using Directives

using NUnit.Framework;
using Project.Euler.Math;

#endregion

namespace ProjectEuler.Test.Math
{
   /// <summary>
   /// DivisorsTest
   /// </summary>
   [TestFixture]
   public class DivisorsTest
   {
      [TestCase( 1U, new uint[] { } )]
      [TestCase( 3U, new[] { 3U } )]
      [TestCase( 6U, new[] { 2U,3U } )]
      [TestCase( 10U, new[] { 2U,5U } )]
      [TestCase( 15U, new[] { 3U,5U } )]
      [TestCase( 21U, new[] { 3U,7U } )]
      [TestCase( 28U, new[] { 2U, 7U } )]
      public void TestPrimeDivisors( uint n, uint[] divisors )
      {
         int i = 0;
         foreach (uint primeDivisor in Divisors.PrimeDivisors(n))
         {
            Assert.Less( i, divisors.Length );
            Assert.AreEqual( divisors[i++], primeDivisor );
         }
      }

      [TestCase( 1U, new[] { 1U } )]
      [TestCase( 3U, new[] { 1U, 3U } )]
      [TestCase( 6U, new[] { 1U, 2U, 3U, 6U } )]
      [TestCase( 10U, new[] { 1U, 2U, 5U, 10U } )]
      [TestCase( 15U, new[] { 1U, 3U, 5U, 15U } )]
      [TestCase( 21U, new[] { 1U, 3U, 7U, 21U } )]
      [TestCase( 28U, new[] { 1U, 2U, 4U, 7U, 14U, 28U } )]
      public void TestDivisors( uint n, uint[] divisors )
      {
         int i = 0;
         foreach ( uint divisor in Divisors.AllDivisors( n ) )
         {
            Assert.Less( i, divisors.Length, "Expected {0}<{1} for number {2}", i, divisors.Length, n );
            Assert.AreEqual( divisors[i++], divisor );
         }
      }

      [TestCase( 1U, 1U )]
      [TestCase( 3U, 2U )]
      [TestCase( 6U, 4U )]
      [TestCase( 10U, 4U )]
      [TestCase( 15U, 4U )]
      [TestCase( 21U, 4U )]
      [TestCase( 28U, 6U )]
      public void TestNumberOfDivisors( uint n, uint expected )
      {
         Assert.AreEqual( expected, Divisors.NumberOfDivisors( n ) );
      }
   }
}