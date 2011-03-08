using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Project.Euler.Math;

namespace ProjectEuler.Test.Math
{
   [TestFixture]
   public class BigIntTest
   {
      [Test]
      public void TestDefaultConstructor()
      {
         BigInt bi = new BigInt();
         Assert.AreEqual( "0", bi.ToString() );
      }

      [TestCase( "", "0" )]
      [TestCase( "0", "0" )]
      [TestCase( "1", "1" )]
      [TestCase( "100", "100" )]
      [TestCase( "101", "101" )]
      [TestCase( "1234567890", "1234567890" )]
      [TestCase( "01", "1" )]
      [TestCase( "000010001", "10001" )]
      public void TestConstructor( string value, string expected )
      {
         BigInt bi = new BigInt( value );
         Assert.AreEqual( expected, bi.ToString() );
      }

      [TestCase( "", "", "0" )]
      [TestCase( "0", "0", "0" )]
      [TestCase( "0", "1", "1" )]
      [TestCase( "9", "1", "10" )]
      [TestCase( "99", "1", "100" )]
      [TestCase( "1", "99", "100" )]
      [TestCase( "99", "99", "198" )]
      [TestCase( "100", "100", "200" )]
      [TestCase( "987654321", "987654321", "1975308642" )]
      [TestCase( "987654321", "987654321987654321", "987654322975308642" )]
      [TestCase( "987654321987654321", "987654321", "987654322975308642" )]
      public void TestAdd( string a, string b, string expected )
      {
         BigInt bi = new BigInt( a );
         bi.Add( b );
         Assert.AreEqual( expected, bi.ToString() );
      }
   }
}
