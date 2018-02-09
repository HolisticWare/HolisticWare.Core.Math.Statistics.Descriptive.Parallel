using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace Core.Math.Statistics.Descriptive.Parallel
{
    /// <summary>
    /// Correlation
    /// </summary>
    public static class IEnumerableExtensionsFrequencies
    {
        public static IEnumerable<KeyValuePair<T, uint>> Frequencies<T>(this IEnumerable<T> x)
        {
            Dictionary<T, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<T, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<ushort, uint>> Frequencies(this IEnumerable<ushort> x)
        {
            Dictionary<ushort, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<ushort, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<short, uint>> Frequencies(this IEnumerable<short> x)
        {
            Dictionary<short, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<short, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<int, uint>> Frequencies(this IEnumerable<int> x)
        {
            Dictionary<int, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<int, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<uint, uint>> Frequencies(this IEnumerable<uint> x)
        {
            Dictionary<uint, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<uint, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<long, uint>> Frequencies(this IEnumerable<long> x)
        {
            Dictionary<long, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<long, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<ulong, uint>> Frequencies(this IEnumerable<ulong> x)
        {
            Dictionary<ulong, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<ulong, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<float, uint>> Frequencies(this IEnumerable<float> x)
        {
            Dictionary<float, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<float, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<double, uint>> Frequencies(this IEnumerable<double> x)
        {
            Dictionary<double, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<double, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<decimal, uint>> Frequencies(this IEnumerable<decimal> x)
        {
            Dictionary<decimal, uint> frequencies = x.FrequencyCounter();

            IEnumerable<KeyValuePair<decimal, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

    }
}
