using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;
using Project.Euler.Math;

namespace ProjectEuler.Test.Math
{
    [TestFixture]
    public class UtilityTest
    {
        [Test]
        [Row( "", 0 )]
        [Row( "1", 1 )]
        [Row( "1234", 10 )]
        [Row( "123455", 20 )]
        public void TestSum( string number, long expected )
        {
            long sum = Utility.Sum(number);
            Assert.AreEqual( expected, sum );
        }

        [Test]
        [Row( 0U, 0U )]
        [Row( 1U, 0U )]
        [Row( 1234U, 123U )]
        [Row( 123455U, 12345U )]
        public void TestTruncateRight( uint number, uint expected )
        {
            uint truncated = Utility.TruncateRight(number);
            Assert.AreEqual( expected, truncated );
        }

        [Test]
        [Row( 0U, 0U )]
        [Row( 1U, 0U )]
        [Row( 10U, 0U )]
        [Row( 12U, 2U )]
        [Row( 1234U, 234U )]
        [Row( 123455U, 23455U )]
        public void TestTruncateLeft( uint number, uint expected )
        {
            uint truncated = Utility.TruncateLeft( number );
            Assert.AreEqual( expected, truncated );
        }
    }
}
