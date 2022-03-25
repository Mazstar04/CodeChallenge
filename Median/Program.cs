using System;

namespace Median
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Median(new int[]{1,2}, new int[] {3,4}));
        }
        public static double Median(int[] firstArray, int[] secondArray)
        {
            double totalLength = firstArray.Length+secondArray.Length;
            double median = (totalLength + 1)/2;
            return median;
        }
    }
}
