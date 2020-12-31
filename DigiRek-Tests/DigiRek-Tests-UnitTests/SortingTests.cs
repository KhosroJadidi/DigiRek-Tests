using DigiRek_Tests.Helper_Methods.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DigiRek_Tests_UnitTests
{
    [TestClass]
    [TestCategory("Sorting Tests")]
    public class SortingTests
    {
        [TestMethod]
        public void SwapTest()
        {
            var array = new double[] { 1, 2 };
            array.Swap(0, 1);
            var expected = new double[] { 2, 1 };
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], expected[i]);
            }
        }
        [TestMethod]
        public void BubbleSortTest()
        {
            var array = new double[] { 3, 2, 1 };
            array.BubbleSort(array.Length);
            var expected = new double[] { 1, 2, 3 };
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], expected[i]);
            }
        }
        [TestMethod]
        public void SortAscendingRecursiveTest()
        {
            var array = new double[] { 3, 2, 1 };
            var sortedArray = array.SortAscendingRecursive();
            var expected = new double[] { 1, 2, 3 };
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], expected[i]);
            }
        }
        [TestMethod]
        public void SortAscendingLinqTest()
        {
            var array = new double[] { 3, 2, 1 };
            var sortedArray = array.SortAscendingLinq();
            var expected = new double[] { 1, 2, 3 };
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(sortedArray[i], expected[i]);
            }
        }
    }
}