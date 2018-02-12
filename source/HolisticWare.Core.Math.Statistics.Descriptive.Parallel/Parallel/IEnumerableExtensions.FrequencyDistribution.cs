using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive.Parallel
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static class IEnumerableExtensionsFrequencyDistibution
    {
        public static IEnumerable<KeyValuePair<T, uint>> FrequencyDistribution<T>(this IEnumerable<T> x)
        {
            ConcurrentDictionary<T, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<T, uint>> frequencies_sorted =
                from pair in frequencies
                    orderby pair.Key ascending
                    select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<ushort, uint>> FrequencyDistribution(this IEnumerable<ushort> x)
        {
            ConcurrentDictionary<ushort, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<ushort, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<short, uint>> FrequencyDistribution(this IEnumerable<short> x)
        {
            ConcurrentDictionary<short, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<short, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<int, uint>> FrequencyDistribution(this IEnumerable<int> x)
        {
            ConcurrentDictionary<int, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<int, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<uint, uint>> FrequencyDistribution(this IEnumerable<uint> x)
        {
            ConcurrentDictionary<uint, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<uint, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<long, uint>> FrequencyDistribution(this IEnumerable<long> x)
        {
            ConcurrentDictionary<long, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<long, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<ulong, uint>> FrequencyDistribution(this IEnumerable<ulong> x)
        {
            ConcurrentDictionary<ulong, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<ulong, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<float, uint>> FrequencyDistribution(this IEnumerable<float> x)
        {
            ConcurrentDictionary<float, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<float, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<double, uint>> FrequencyDistribution(this IEnumerable<double> x)
        {
            ConcurrentDictionary<double, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<double, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<decimal, uint>> FrequencyDistribution(this IEnumerable<decimal> x)
        {
            ConcurrentDictionary<decimal, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<decimal, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

    }
}
