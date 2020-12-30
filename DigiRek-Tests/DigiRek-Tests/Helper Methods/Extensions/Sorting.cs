using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiRek_Tests.HelperMethods.Extensions
{
    public static class Sorting
    {
        public static void Swap(this double[] source, int firstIndex, int secondIndex)
        {
            var secondElement = source[secondIndex];
            source[secondIndex] = source[firstIndex];
            source[firstIndex] = secondElement;
        }
        public static void BubbleSort(this double[] array, int length)
        {
            if (length == 1)
                return;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    Swap(array, i, i + 1);
            }
            BubbleSort(array, length - 1);
        }
        public static double[] SortAscendingRecursive(this double[] numbers)
        {
            var array = (double[])numbers.Clone();
            BubbleSort(array, numbers.Length);
            return array;
        }
        public static double[] SortAscendingLinq(this double[] numbers)
        {
            return numbers.OrderBy(n => n)
                .ToArray();
        }
    }
}
