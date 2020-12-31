using DigiRek_Tests.Handlers;
using DigiRek_Tests_UnitTests.HelperMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DigiRek_Tests_UnitTests
{
    [TestClass]
    [TestCategory("Input Handlers Tests")]
    public class InputHandlersTests
    {
        private readonly InputHandlers _sut
            = InputHandlers.Instance;

        [TestMethod]
        public void ReadInputTest()
        {
            StringMethods.SetupStringReader(" lowerCase ");
            var actual = _sut.ReadInput();
            var expected = "LOWERCASE";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HandleWrongInputTest()
        {
            var stringWriter =
                StringMethods.SetupStringWriter();
            _sut.HandleWrongInput();
            var actual = stringWriter.ToString();
            var expected = "Wrong input. Please try again."
                + Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HandleQuitTest()
        {
            var stringWriter =
                StringMethods.SetupStringWriter();
            _sut.HandleQuit();
            var actual = stringWriter.ToString();
            var expected = "Thanks for using this application!"
                + Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InvokeHandlerTest()
        {
            var stringWriter =
                StringMethods.SetupStringWriter();
            var keyValuePair =
                new KeyValuePair<string, Action>
                ("name", _sut.HandleWrongInput);
            var loopShouldEnd = false;
            var askedToQuit = false;
            _sut.InvokeHandler
                (keyValuePair
                , out loopShouldEnd
                , out askedToQuit);
            var actual = stringWriter.ToString();
            var expected = "Wrong input. Please try again."
                + Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HandleInputIncorrectTest()
        {
            var stringWriter =
                StringMethods.SetupStringWriter();
            var askedToQuit = false;
            _sut.HandleInput("wrong input", out askedToQuit);
            var actual = stringWriter.ToString();
            var expected = "Wrong input. Please try again."
                + Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HandleInputCorrectTest()
        {
            var stringWriter =
                StringMethods.SetupStringWriter();
            var askedToQuit = false;
            _sut.HandleInput("QUIT", out askedToQuit);
            var actual = stringWriter.ToString();
            var expected = "Thanks for using this application!"
                + Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }
    }
}