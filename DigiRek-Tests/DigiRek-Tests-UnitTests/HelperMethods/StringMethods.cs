using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static StringReader SetupStringReader(string input)
        {
            var stringReader = new StringReader(" lowerCase ");
            Console.SetIn(stringReader);
            return stringReader;
        }
    }
}
