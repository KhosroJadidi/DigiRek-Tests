using DigiRek_Tests.Displayers;
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
    public class MessagesTests
    {
        private readonly Messages sut = Messages.Instance;
        private readonly string[] choices = new[]
        {
            "Sum of all numbers (sum)",
            "Average of all numbers (average)",
            "[X] Highest number (top X),where x is a positive integer",
            "Map all values to a collection of key-value pairs (map)"
        };

        [TestMethod]
        public void PrintWelcomeTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            sut.PrintWelcome();
            var actual = stringWriter.ToString();
            var expected = "Welcome!"
                + Environment.NewLine
                + "Please choose the statistic that you need."
                + Environment.NewLine
                + "Type in the word inside the parentheses and press ENTER."
                + Environment.NewLine
                + Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrintChoicesTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            sut.PrintChoices();
            var actual = stringWriter.ToString();
            var expected =
                "Sum of all numbers (sum)"
                + Environment.NewLine
                + Environment.NewLine
                + "Average of all numbers (average)"
                + Environment.NewLine
                + Environment.NewLine
                + "[X] Highest number (top X),where x is a positive integer"
                + Environment.NewLine
                + Environment.NewLine
                + "Map all values to a collection of key-value pairs (map)"
                + Environment.NewLine
                + Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }
    }
}
