using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRek_Tests.HelperMethods
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
            var average= Addition.Instance
                .Sum(array) / array.Length;
            return Math.Round(average, 2);
        }

        public double AverageLinq(double[] array)
        {
            var avergae= array.Average();
            return Math.Round(avergae, 2);
        }
    }
}
