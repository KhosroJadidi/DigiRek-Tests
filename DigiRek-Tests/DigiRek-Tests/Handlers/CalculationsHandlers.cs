using DigiRek_Tests.Data_Storage;
using DigiRek_Tests.Helper_Methods;
using DigiRek_Tests.Helper_Methods.Extensions;
using System;

namespace DigiRek_Tests.Handlers
{
    public sealed class CalculationsHandlers
    {
        private CalculationsHandlers()
        {
            numbers = Numbers.GivenNumbers;
        }

        public static CalculationsHandlers Instance =
            new CalculationsHandlers();

        private double[] numbers;

        public void HandleSum()
        {
            var sum = Addition.Instance.Sum(numbers);
            Console.WriteLine($"The sum of all numbers is {sum}.");
        }

        public void HandleAverage()
        {
            var average = Division.Instance.Average(numbers);
            Console.WriteLine($"The average of all numbers is {average}.");
        }

        public void HandleTopThree()
        {
            var sortedArray = numbers.SortAscendingRecursive();
            var message = "The three largest numbers are:";
            for (int i = sortedArray.Length - 1; i > sortedArray.Length - 4; i--)
            {
                message += Environment.NewLine
                    + sortedArray[i];
            }
            Console.WriteLine(message);
        }

        public void HandleMapping()
        {
            var message = string.Empty;
            var givenNumbers = Numbers.GivenNumbers;
            for (int i = 1; i < givenNumbers.Length + 1; i++)
            {
                message +=
                    $"Customer {i}: {givenNumbers[i - 1]}"
                    + Environment.NewLine;
            }
            Console.WriteLine(message);
        }
    }
}