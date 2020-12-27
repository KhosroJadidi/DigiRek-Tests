using DigiRek_Tests.Handlers;
using DigiRek_Tests_UnitTests.HelperMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRek_Tests_UnitTests
{
    [TestClass]
    [TestCategory("Input Handlers Tests")]
    public class InputHandlersTests
    {
        private readonly InputHandlers sut
            = InputHandlers.Instance;

        [TestMethod]
        public void ReadInputTest()
        {
            StringReader stringReader = 
                StringMethods.SetupStringReader(" lowerCase ");
            var actual = sut.ReadInput();
            var expected = "LOWERCASE";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HandleWrongInputTest()
        {
            var stringWriter =
                StringMethods.SetupStringWriter();
            sut.HandleWrongInput();
            var actual = stringWriter.ToString();
            var expected = "Wrong input. Please try again."
                +Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HandleQuitTest()
        {
            var stringWriter =
                StringMethods.SetupStringWriter();
            sut.HandleQuit();
            var actual = stringWriter.ToString();
            var expected = "Thank's for using this application!"
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
                ("name", sut.HandleWrongInput);
            sut.InvokeHandler(keyValuePair);
            var actual = stringWriter.ToString();
            var expected = "Wrong input. Please try again."
                +Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HandleInputIncorrectTest()
        {
            var stringWriter =
                StringMethods.SetupStringWriter();
            var askedToQuit = false;
            sut.HandleInput("wrong input",out askedToQuit);
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
            sut.HandleInput("QUIT",out askedToQuit);
            var actual = stringWriter.ToString();
            var expected = "Thank's for using this application!"
                + Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }
    }
}
