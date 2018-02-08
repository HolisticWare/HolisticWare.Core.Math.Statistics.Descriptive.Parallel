using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive.Parallel
{
    /// <summary>
    /// Correlation
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Correlation_and_dependence"/> 
    /// <see cref="http://www.mathsisfun.com/data/correlation.html"/>
    public static class IEnumerableExtensionsMeanArithmetic
    {
        public static double MeanArithmetic(this IEnumerable<ushort> x)
        {
            return x.Cast<int>().Average();
        }

        public static double MeanArithmetic(this IEnumerable<short> x)
        {
            return x.Cast<int>().Average();
        }

        public static double MeanArithmetic(this IEnumerable<int> x)
        {
            return x.Average();
        }

        public static double MeanArithmetic(this IEnumerable<uint> x)
        {
            return x.Cast<long>().Average();
        }

        public static double MeanArithmetic(this IEnumerable<long> x)
        {
            return x.Average();
        }

        public static double MeanArithmetic(this IEnumerable<ulong> x)
        {
            return x.Cast<double>().Average();
        }

        public static double MeanArithmetic(this IEnumerable<float> x)
        {
            return x.Average();
        }
         
        public static double MeanArithmetic(this IEnumerable<double> x)
        {
            return x.Average();
        }

        public static decimal MeanArithmetic(this IEnumerable<decimal> x)
        {
            return x.Average();
        }

    }
}
