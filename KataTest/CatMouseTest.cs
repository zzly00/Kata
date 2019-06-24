using Kata;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class CatAndMouseTest
    {
        [Test]
        [TestCase("Escaped!", "C....m", TestName = "C....m should be Escaped!")]
        [TestCase("Escaped!", "C.........m", TestName = "C.........m should be Escaped!")]
        [TestCase("Caught!", "C..m", TestName = "C..m should be Caught!")]
        [TestCase("Caught!", "Cm", TestName = "Cm should be Caught!")]
        public void Test(string expected, string x)
        {
            var kata = new CatAndMouseKata();
            var actual = kata.CatAndMouse(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
