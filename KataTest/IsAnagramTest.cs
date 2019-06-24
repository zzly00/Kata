using Kata;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class IsAnagramTest
    {
        [Test]
        [TestCase(true, "foefet", "toffee", TestName = "foefet and toffee should be true")]
        [TestCase(true, "Buckethead", "DeathCubeK", TestName = "Buckethead and DeathCubeK should be true")]
        [TestCase(true, "Twoo", "Woot", TestName = "Twoo and Woot should be true")]
        [TestCase(false, "apple", "pale", TestName = "apple and pale should be false")]
        [TestCase(false, "restful", "flust", TestName = "restful and flust should be false")]
        [TestCase(true, "customers", "store scum", TestName = "customers and store scum should be true")]
        public void Test(bool expected, string test, string original)
        {
            var kata = new IsAnagramKata();
            var actual = kata.IsAnagram(test, original);
            Assert.AreEqual(expected, actual);
        }
    }
}