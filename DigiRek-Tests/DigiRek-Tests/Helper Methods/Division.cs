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
            return Addition.Instance
                .Sum(array) / array.Length;
        }

        public double AverageLinq(double[] array)
        {
            return array.Average();
        }
    }
}
