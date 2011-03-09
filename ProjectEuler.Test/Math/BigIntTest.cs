using MbUnit.Framework;
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

      [Test]
      [Row( "", "0" )]
      [Row( "0", "0" )]
      [Row( "1", "1" )]
      [Row( "100", "100" )]
      [Row( "101", "101" )]
      [Row( "1234567890", "1234567890" )]
      [Row( "01", "1" )]
      [Row( "000010001", "10001" )]
      public void TestConstructor( string value, string expected )
      {
         BigInt bi = new BigInt( value );
         Assert.AreEqual( expected, bi.ToString() );
      }

      [Row( "", "", "0" )]
      [Row( "0", "0", "0" )]
      [Row( "0", "1", "1" )]
      [Row( "9", "1", "10" )]
      [Row( "99", "1", "100" )]
      [Row( "1", "99", "100" )]
      [Row( "99", "99", "198" )]
      [Row( "100", "100", "200" )]
      [Row( "987654321", "987654321", "1975308642" )]
      [Row( "987654321", "987654321987654321", "987654322975308642" )]
      [Row( "987654321987654321", "987654321", "987654322975308642" )]
      public void TestAdd( string a, string b, string expected )
      {
         BigInt bi = new BigInt( a );
         bi.Add( b );
         Assert.AreEqual( expected, bi.ToString() );
      }
   }
}
