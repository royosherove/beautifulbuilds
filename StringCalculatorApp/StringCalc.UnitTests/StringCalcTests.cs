using NUnit.Framework;
using StringCalc.Lib;

namespace StringCalc.UnitTests
{
    [TestFixture]
    public class StringCalcTests
    {
        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            StringCalculator sc = new StringCalculator();

            int result = sc.Add("");

            Assert.AreEqual(0,result);
        }

    }
}
