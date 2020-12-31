using DigiRek_Tests.Displayers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace DigiRek_Tests_UnitTests
{
    [TestClass]
    [TestCategory("Messages Tests")]
    public class MessagesTests
    {
        private readonly string[] _choices = new[]
        {
            "Sum of all numbers (sum)",
            "Average of all numbers (average)",
            "Top 3 numbers (top),where x is a positive integer",
            "Map all values to a collection of key-value pairs (map)",
            "Quit the application (quit)"
        };

        [TestMethod]
        public void PrintWelcomeTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Messages.PrintWelcome();
            var actual = stringWriter.ToString();
            var expected = "Welcome!"
                + Environment.NewLine
                + "Type in the word inside the parentheses to run the desired command, and press Enter."
                + Environment.NewLine
                + "You may also enter an entire sentence that contains the desired word."
                + Environment.NewLine
                + "If a Sentence contains several of such words, the application will use the first word."
                + Environment.NewLine
                + Environment.NewLine;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrintChoicesTest()
        {
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            Messages.PrintChoices();
            var actual = stringWriter.ToString();
            var expected = string.Empty;
            foreach (var item in _choices)
            {
                expected +=
                    Environment.NewLine
                    + item
                    + Environment.NewLine
                    + Environment.NewLine;
            }
            Assert.AreEqual(expected, actual);
        }
    }
}