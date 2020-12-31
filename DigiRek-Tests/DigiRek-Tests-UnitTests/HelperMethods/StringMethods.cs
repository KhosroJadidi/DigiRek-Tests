using System;
using System.IO;

namespace DigiRek_Tests_UnitTests.HelperMethods
{
    public static class StringMethods
    {
        public static StringWriter SetupStringWriter()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            return stringWriter;
        }
        public static void SetupStringReader(string input)
        {
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);
        }
    }
}