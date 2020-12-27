using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRek_Tests.Displayers
{
    public sealed class Messages
    {
        private Messages()
        {
        }
        private readonly string[] choices = new[]
        {
            "Sum of all numbers (sum)",
            "Average of all numbers (average)",
            "Top 3 numbers (top),where x is a positive integer",
            "Map all values to a collection of key-value pairs (map)",
            "Quit the application (quit)"
        };

        public static Messages Instance { get; }
            = new Messages();

        public void PrintChoices()
        {
            foreach (var choice in choices)
            {
                var text = choice + Environment.NewLine;
                Console.WriteLine(text);
            }
        }

        public void PrintWelcome()
        {
            var message = "Welcome!"
                +Environment.NewLine
                +"Please choose the statistic that you need."
                +Environment.NewLine
                +"Type in the word inside the parentheses and press ENTER."
                +Environment.NewLine;
            Console.WriteLine(message);
        }

    }
}
