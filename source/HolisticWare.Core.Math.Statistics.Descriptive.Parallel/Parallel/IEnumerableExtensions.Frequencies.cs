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
            long n = x.LongCount();

            Dictionary<T, uint> frequencies = new Dictionary<T, uint>((int) n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                T x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            IEnumerable<KeyValuePair<T, uint>> frequencies_sorted =
                from pair in frequencies
                    orderby pair.Value descending
                    select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<ushort, uint>> Frequencies(this IEnumerable<ushort> x)
        {
            long n = x.LongCount();

            Dictionary<ushort, uint> frequencies = new Dictionary<ushort, uint>((int) n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                ushort x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            IEnumerable<KeyValuePair<ushort, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<short, uint>> Frequencies(this IEnumerable<short> x)
        {
            long n = x.LongCount();

            Dictionary<short, uint> frequencies = new Dictionary<short, uint>((int)n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                short x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            IEnumerable<KeyValuePair<short, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<int, uint>> Frequencies(this IEnumerable<int> x)
        {
            long n = x.LongCount();

            Dictionary<int, uint> frequencies = new Dictionary<int, uint>((int)n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                int x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            IEnumerable<KeyValuePair<int, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<uint, uint>> Frequencies(this IEnumerable<uint> x)
        {
            long n = x.LongCount();

            Dictionary<uint, uint> frequencies = new Dictionary<uint, uint>((int)n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                uint x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            IEnumerable<KeyValuePair<uint, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<long, uint>> Frequencies(this IEnumerable<long> x)
        {
            long n = x.LongCount();

            Dictionary<long, uint> frequencies = new Dictionary<long, uint>((int)n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                long x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            IEnumerable<KeyValuePair<long, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<ulong, uint>> Frequencies(this IEnumerable<ulong> x)
        {
            long n = x.LongCount();

            Dictionary<ulong, uint> frequencies = new Dictionary<ulong, uint>((int)n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                ulong x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            IEnumerable<KeyValuePair<ulong, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<float, uint>> Frequencies(this IEnumerable<float> x)
        {
            long n = x.LongCount();

            Dictionary<float, uint> frequencies = new Dictionary<float, uint>((int)n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                float x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            IEnumerable<KeyValuePair<float, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<double, uint>> Frequencies(this IEnumerable<double> x)
        {
            long n = x.LongCount();

            Dictionary<double, uint> frequencies = new Dictionary<double, uint>((int)n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                double x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            IEnumerable<KeyValuePair<double, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

        public static IEnumerable<KeyValuePair<decimal, uint>> Frequencies(this IEnumerable<decimal> x)
        {
            long n = x.LongCount();

            Dictionary<decimal, uint> frequencies = new Dictionary<decimal, uint>((int)n);

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                decimal x_i = x.ElementAt((int)i);
                                if (frequencies.ContainsKey(x_i))
                                {
                                    frequencies[x_i] += 1;
                                }
                                else
                                {
                                    frequencies.Add(x_i, 1);
                                }
                            }
                        );

            IEnumerable<KeyValuePair<decimal, uint>> frequencies_sorted =
                from pair in frequencies
                orderby pair.Value descending
                select pair
                    ;

            return frequencies_sorted;
        }

    }
}
