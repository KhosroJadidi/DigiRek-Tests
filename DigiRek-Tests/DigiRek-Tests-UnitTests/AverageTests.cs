using DigiRek_Tests.HelperMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRek_Tests_UnitTests
{
    [TestClass]
    [TestCategory("Average Tests")]
    public class AverageTests
    {
        private readonly double[] array = new double[] { 10, 20, 30 };

        [TestMethod]
        public void AverageTest()
        {
            var sut = Division.Instance;
            var actual = sut.Average(array);
            var expected = 20;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AverageLinqTest()
        {
            var sut = Division.Instance;
            var actual = sut.AverageLinq(array);
            var expected = 20;
            Assert.AreEqual(expected, actual);
        }
    }
}
