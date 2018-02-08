using System;
using System.Collections.Generic;
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
            long n = x.LongCount();

            Dictionary<T, uint> frequencies = new Dictionary<T, uint>((int) n);

            for (int i = 0; i < n; i++)
            {
                T x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            IEnumerable<KeyValuePair<T, uint>> frequencies_sorted =
                from pair in frequencies
                    orderby pair.Key ascending
                    select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<ushort, uint>> FrequencyDistribution(this IEnumerable<ushort> x)
        {
            long n = x.LongCount();

            Dictionary<ushort, uint> frequencies = new Dictionary<ushort, uint>((int) n);

            for (int i = 0; i < n; i++)
            {
                ushort x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }                
            }

            IEnumerable<KeyValuePair<ushort, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<short, uint>> FrequencyDistribution(this IEnumerable<short> x)
        {
            long n = x.LongCount();

            Dictionary<short, uint> frequencies = new Dictionary<short, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                short x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            IEnumerable<KeyValuePair<short, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<int, uint>> FrequencyDistribution(this IEnumerable<int> x)
        {
            long n = x.LongCount();

            Dictionary<int, uint> frequencies = new Dictionary<int, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                int x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            IEnumerable<KeyValuePair<int, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<uint, uint>> FrequencyDistribution(this IEnumerable<uint> x)
        {
            long n = x.LongCount();

            Dictionary<uint, uint> frequencies = new Dictionary<uint, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                uint x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            IEnumerable<KeyValuePair<uint, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<long, uint>> FrequencyDistribution(this IEnumerable<long> x)
        {
            long n = x.LongCount();

            Dictionary<long, uint> frequencies = new Dictionary<long, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                long x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            IEnumerable<KeyValuePair<long, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<ulong, uint>> FrequencyDistribution(this IEnumerable<ulong> x)
        {
            long n = x.LongCount();

            Dictionary<ulong, uint> frequencies = new Dictionary<ulong, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                ulong x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            IEnumerable<KeyValuePair<ulong, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<float, uint>> FrequencyDistribution(this IEnumerable<float> x)
        {
            long n = x.LongCount();

            Dictionary<float, uint> frequencies = new Dictionary<float, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                float x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            IEnumerable<KeyValuePair<float, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<double, uint>> FrequencyDistribution(this IEnumerable<double> x)
        {
            long n = x.LongCount();

            Dictionary<double, uint> frequencies = new Dictionary<double, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                double x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            IEnumerable<KeyValuePair<double, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<decimal, uint>> FrequencyDistribution(this IEnumerable<decimal> x)
        {
            long n = x.LongCount();

            Dictionary<decimal, uint> frequencies = new Dictionary<decimal, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                decimal x_i = x.ElementAt(i);
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[x_i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            IEnumerable<KeyValuePair<decimal, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }

        #if NETSTANDARD1_3
        [Obsolete("Performance issue (boxing)")]
        public static IEnumerable<KeyValuePair<object, uint>> FrequencyDistribution(this System.Collections.ArrayList x)
        {
            long n = x.Count;

            Dictionary<object, uint> frequencies = new Dictionary<object, uint>((int)n);

            for (int i = 0; i < n; i++)
            {
                object x_i = x[i];
                if (frequencies.ContainsKey(x_i))
                {
                    frequencies[i] += 1;
                }
                else
                {
                    frequencies.Add(x_i, 1);
                }
            }

            IEnumerable<KeyValuePair<object, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Key ascending
                select pair
                    ;

            return frequencies_sorted;
        }
        #endif
    }
}
