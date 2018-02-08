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
    public static class IEnumerableExtensionsMeanGeometric
    {
        public static double MeanGeometric(this IEnumerable<ushort> x)
        {
            double product = 1.0;

            foreach (ushort x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<short> x)
        {
            double product = 1.0;

            foreach (ushort x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<int> x)
        {
            double product = 1.0;

            foreach (ushort x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<uint> x)
        {
            double product = 1.0;

            foreach (ushort x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<long> x)
        {
            double product = 1.0;

            foreach (ushort x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<ulong> x)
        {
            double product = 1.0;

            foreach (ushort x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<float> x)
        {
            double product = 1.0;

            foreach (ushort x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<double> x)
        {
            double product = 1.0;

            foreach (ushort x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }

        public static double MeanGeometric(this IEnumerable<decimal> x)
        {
            double product = 1.0;

            foreach (ushort x_i in x)
            {
                product *= x_i;
            }

            return System.Math.Pow(product, 1.0 / x.LongCount());
        }
    }
}
