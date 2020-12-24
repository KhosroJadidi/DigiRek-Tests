using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRek_Tests
{
    [TestClass]
    [TestCategory("Addition Tests")]
    public class AdditionTests
    {
        private readonly double[] array= new double[]{10,20,30};

        [TestMethod]
        public void SimpleAdditionTest()
        {
            var sut = Addition.Instance;
            var actual =sut.Sum(array);
            var expected = 60;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LinqAdditionTest()
        {
            var sut = Addition.Instance;
            var actual = sut.SumLinq(array);
            var expected = 60;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RecursiveSumTest()
        {
            var sut = Addition.Instance;
            var actual = sut.SumRecursive(array);
            var expected = 60;
            Assert.AreEqual(expected, actual);
        }
    }
}    
