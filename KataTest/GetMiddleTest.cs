using Kata;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class GetMiddleTest
    {
        [Test]
        [TestCase("es", "test", TestName = "test should be es")]
        [TestCase("t", "testing", TestName = "testing should be t")]
        [TestCase("dd", "middle", TestName = "middle should be dd")]
        [TestCase("A", "A", TestName = "A should be A")]
        [TestCase("p", "apple", TestName = "apple should be p")]
        [TestCase("tt", "nexttime", TestName = "nexttime should be Testest")]
        public void Test(string expected, string s)
        {
            var kata = new GetMiddleKata();
            var actual = kata.GetMiddle(s);
            Assert.AreEqual(expected, actual);
        }
    }
}