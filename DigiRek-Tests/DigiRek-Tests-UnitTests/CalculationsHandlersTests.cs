﻿using DigiRek_Tests.Data_Storage;
using DigiRek_Tests.Handlers;
using DigiRek_Tests_UnitTests.HelperMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DigiRek_Tests_UnitTests
{
    [TestClass]
    [TestCategory("Calculations Handlers Tests")]
    public class CalculationsHandlersTests
    {
        private readonly CalculationsHandlers _sut
            = CalculationsHandlers.Instance;
        [TestMethod]
        public void HandleSumTest()
        {
            var stringWriter = StringMethods.SetupStringWriter();
            _sut.HandleSum();
            var expected = "The sum of all numbers is 2969."
                + Environment.NewLine;
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HandleAverageTest()
        {
            var stringWriter = StringMethods.SetupStringWriter();
            _sut.HandleAverage();
            var expected = "The average of all numbers is 228,38."
                + Environment.NewLine;
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HandleTopThreeTest()
        {
            var stringWriter = StringMethods.SetupStringWriter();
            _sut.HandleTopThree();
            var expected = "The three largest numbers are:"
                + Environment.NewLine
                + 1000
                + Environment.NewLine
                + 800
                + Environment.NewLine
                + 600
                + Environment.NewLine;
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HandleMappingTest()
        {
            var stringWriter = StringMethods.SetupStringWriter();
            _sut.HandleMapping();
            var numbers = Numbers.GivenNumbers;
            var expected = string.Empty;
            for (int i = 1; i < numbers.Length + 1; i++)
            {
                expected +=
                    $"Customer {i}: {numbers[i - 1]}"
                    + Environment.NewLine;
            }
            expected += Environment.NewLine;
            var actual = stringWriter.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}