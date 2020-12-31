using DigiRek_Tests.Helper_Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DigiRek_Tests_UnitTests
{
    [TestClass]
    [TestCategory("Average Tests")]
    public class AverageTests
    {
        private readonly Division _sut = Division.Instance;
        private readonly double[] _array = new double[] { 10, 20, 30 };

        [TestMethod]
        public void AverageTest()
        {
            var actual = _sut.Average(_array);
            var expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AverageLinqTest()
        {
            var actual = _sut.AverageLinq(_array);
            var expected = 20;
            Assert.AreEqual(expected, actual);
        }
    }
}