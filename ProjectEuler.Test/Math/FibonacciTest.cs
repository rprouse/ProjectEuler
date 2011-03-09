using System.Numerics;
using MbUnit.Framework;
using Project.Euler.Math;

namespace ProjectEuler.Test.Math
{
    [TestFixture]
    public class FibonacciTest
    {
        [Test]
        public void TestSequence()
        {
            int[] sequence = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144};
            int i = 0;
            foreach (BigInteger value in Fibonacci.Values)
            {
                Assert.AreEqual( sequence[i++], value );
                if ( i == sequence.Length )
                    break;
            }
        }
    }
}
