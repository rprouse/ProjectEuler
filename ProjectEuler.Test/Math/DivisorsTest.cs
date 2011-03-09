#region Using Directives

using MbUnit.Framework;
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
      [Test]
      [Row( 1U, new uint[] { } )]
      [Row( 3U, new[] { 3U } )]
      [Row( 6U, new[] { 2U,3U } )]
      [Row( 10U, new[] { 2U,5U } )]
      [Row( 15U, new[] { 3U,5U } )]
      [Row( 21U, new[] { 3U,7U } )]
      [Row( 28U, new[] { 2U, 7U } )]
      public void TestPrimeDivisors( uint n, uint[] divisors )
      {
         int i = 0;
         foreach (uint primeDivisor in Divisors.PrimeDivisors(n))
         {
            Assert.LessThan( i, divisors.Length );
            Assert.AreEqual( divisors[i++], primeDivisor );
         }
      }

      [Test]
      [Row( 1U, new[] { 1U } )]
      [Row( 3U, new[] { 1U, 3U } )]
      [Row( 6U, new[] { 1U, 2U, 3U, 6U } )]
      [Row( 10U, new[] { 1U, 2U, 5U, 10U } )]
      [Row( 15U, new[] { 1U, 3U, 5U, 15U } )]
      [Row( 21U, new[] { 1U, 3U, 7U, 21U } )]
      [Row( 28U, new[] { 1U, 2U, 4U, 7U, 14U, 28U } )]
      public void TestDivisors( uint n, uint[] divisors )
      {
         int i = 0;
         foreach ( uint divisor in Divisors.AllDivisors( n ) )
         {
            Assert.LessThan( i, divisors.Length, "Expected {0}<{1} for number {2}", i, divisors.Length, n );
            Assert.AreEqual( divisors[i++], divisor );
         }
      }

      [Test]
      [Row( 1U, 1U )]
      [Row( 3U, 2U )]
      [Row( 6U, 4U )]
      [Row( 10U, 4U )]
      [Row( 15U, 4U )]
      [Row( 21U, 4U )]
      [Row( 28U, 6U )]
      public void TestNumberOfDivisors( uint n, uint expected )
      {
         Assert.AreEqual( expected, Divisors.NumberOfDivisors( n ) );
      }
   }
}