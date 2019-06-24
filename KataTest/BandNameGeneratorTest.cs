using Kata;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class BandNameGeneratorTest
    {
        [Test]
        [TestCase("The Knife", "knife", TestName = "knife should be The Knife")]
        [TestCase("Tartart", "tart", TestName = "tart should be Tartart")]
        [TestCase("Sandlesandles", "sandles", TestName = "sandles should be Sandlesandles")]
        [TestCase("The Bed", "bed", TestName = "bed should be The Bed")]
        [TestCase("The Apple", "apple", TestName = "apple should be The Apple")]
        [TestCase("Testest", "Test", TestName = "Test should be Testest")]
        public void Test(string expected, string str)
        {
            var kata = new BandNameGeneratorKata();
            var actual = kata.BandNameGenerator(str);
            Assert.AreEqual(expected, actual);
        }
    }
}