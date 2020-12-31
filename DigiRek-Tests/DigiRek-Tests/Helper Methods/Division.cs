using System;
using System.Linq;

namespace DigiRek_Tests.Helper_Methods
{
    public sealed class Division
    {
        private Division()
        {
        }
        public static Division Instance { get; }
            = new Division();
        public double Average(double[] array)
        {
            var average = Addition.Instance
                .Sum(array) / array.Length;
            return Math.Round(average, 2);
        }
        public double AverageLinq(double[] array)
        {
            var avergae = array.Average();
            return Math.Round(avergae, 2);
        }
    }
}