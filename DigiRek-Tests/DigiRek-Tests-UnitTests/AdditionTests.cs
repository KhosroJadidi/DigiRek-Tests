using DigiRek_Tests.Helper_Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DigiRek_Tests_UnitTests
{
    [TestClass]
    [TestCategory("Addition Tests")]
    public class AdditionTests
    {
        private readonly Addition _sut = Addition.Instance;
        private readonly double[] _array = new double[] { 10, 20, 30 };

        [TestMethod]
        public void SimpleAdditionTest()
        {
            var actual = _sut.Sum(_array);
            var expected = 60;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LinqAdditionTest()
        {
            var actual = _sut.SumLinq(_array);
            var expected = 60;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RecursiveSumTest()
        {
            var actual = _sut.SumRecursive(_array);
            var expected = 60;
            Assert.AreEqual(expected, actual);
        }
    }
}