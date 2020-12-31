using System;
using System.Linq;

namespace DigiRek_Tests.Helper_Methods
{
    public sealed class Addition
    {
        private Addition()
        {
        }

        public static Addition Instance { get; }
            = new Addition();

        public double Sum(double[] array)
        {
            var num = (double[])array.Clone();
            var sum = 0.0;
            for (int i = 0; i < num.Length; i++)
            {
                num[i + 1] += num[i];
                if (i == num.Length - 2)
                {
                    sum = num[i + 1];
                    break;
                }
            }
            return sum;
        }

        public double SumLinq(double[] array)
        {
            return array.Sum();
        }

        public double SumRecursive(double[] array)
        {
            if (array.Length == 1)
                return array[0];
            var newArray = new double[array.Length - 1];
            Array.Copy(array, 1, newArray, 0, array.Length - 1);
            return array[0] + SumRecursive(newArray);
        }
    }
}