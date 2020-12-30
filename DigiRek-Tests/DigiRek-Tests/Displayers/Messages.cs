using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRek_Tests.Displayers
{
    public class Messages
    {
        private Messages()
        {
        }
        private static readonly string[] choices = new[]
        {
            "Sum of all numbers (sum)",
            "Average of all numbers (average)",
            "Top 3 numbers (top),where x is a positive integer",
            "Map all values to a collection of key-value pairs (map)",
            "Quit the application (quit)"
        };
        public static void PrintChoices()
        {
            foreach (var choice in choices)
            {
                var text = 
                    Environment.NewLine
                    + choice 
                    + Environment.NewLine;
                Console.WriteLine(text);
            }
        }
        public static void PrintWelcome()
        {
            var message = "Welcome!"
                +Environment.NewLine
                + "Type in the word inside the parentheses to run the desired command, and press Enter."
                + Environment.NewLine
                + "You may also enter an entire sentence that contains the desired word."
                + Environment.NewLine
                + "If a Sentence contains several of such words, the application will use the first word."
                + Environment.NewLine;
            Console.WriteLine(message);
        }
    }
}
