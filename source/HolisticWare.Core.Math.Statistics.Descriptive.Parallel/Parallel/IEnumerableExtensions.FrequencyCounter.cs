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
    public static class IEnumerableExtensionsFrequencyCounter
    {
        public static ConcurrentDictionary<T, uint> FrequencyCounter<T>(this IEnumerable<T> x)
        {
            long n = x.LongCount();

            ParallelQuery<T> pq = x.AsParallel();

            ConcurrentDictionary<T, uint> frequencies = new ConcurrentDictionary<T, uint>();

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                T x_i = x.ElementAt((int)i);

                                CalculateFrequencyAdd(frequencies, x_i);
                            }
                        );
            
            return frequencies;
        }

        public static void CalculateFrequencyAdd<T>(ConcurrentDictionary<T, uint> frequencies, T x)
        {
            if (!frequencies.TryAdd(x, 1))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static void CalculateFrequencyUpdate<T>(ConcurrentDictionary<T, uint> frequencies, T x)
        {
            uint frequency = frequencies[x];
            if (!frequencies.TryUpdate(x, frequency + 1, frequency))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static ConcurrentDictionary<ushort, uint> FrequencyCounter(this IEnumerable<ushort> x)
        {
            long n = x.LongCount();

            ParallelQuery<ushort> pq = x.AsParallel();

            ConcurrentDictionary<ushort, uint> frequencies = new ConcurrentDictionary<ushort, uint>();

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                ushort x_i = x.ElementAt((int)i);

                                CalculateFrequencyAdd(frequencies, x_i);
                            }
                        );
            
            return frequencies;
        }

        public static void CalculateFrequencyAdd(ConcurrentDictionary<ushort, uint> frequencies, ushort x)
        {
            if (!frequencies.TryAdd(x, 1))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static void CalculateFrequencyUpdate(ConcurrentDictionary<ushort, uint> frequencies, ushort x)
        {
            uint frequency = frequencies[x];
            if (!frequencies.TryUpdate(x, frequency + 1, frequency))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static ConcurrentDictionary<short, uint> FrequencyCounter(this IEnumerable<short> x)
        {
            long n = x.LongCount();

            ConcurrentDictionary<short, uint> frequencies = new ConcurrentDictionary<short, uint>();

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                short x_i = x.ElementAt((int)i);
                                
                                CalculateFrequencyAdd(frequencies, x_i);
                            }
                        );

            return frequencies;
        }

        public static void CalculateFrequencyAdd(ConcurrentDictionary<short, uint> frequencies, short x)
        {
            if (!frequencies.TryAdd(x, 1))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static void CalculateFrequencyUpdate(ConcurrentDictionary<short, uint> frequencies, short x)
        {
            uint frequency = frequencies[x];
            if (!frequencies.TryUpdate(x, frequency + 1, frequency))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static ConcurrentDictionary<int, uint> FrequencyCounter(this IEnumerable<int> x)
        {
            long n = x.LongCount();

            ParallelQuery<int> pq = x.AsParallel();

            ConcurrentDictionary<int, uint> frequencies = new ConcurrentDictionary<int, uint>();

            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                int x_i = x.ElementAt((int)i);

                                CalculateFrequencyAdd(frequencies, x_i);
                            }
                        );

            return frequencies;
        }

        public static void CalculateFrequencyAdd(ConcurrentDictionary<int, uint> frequencies, int x)
        {
            if (!frequencies.TryAdd(x, 1))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static void CalculateFrequencyUpdate(ConcurrentDictionary<int, uint> frequencies, int x)
        {
            uint frequency = frequencies[x];
            if (!frequencies.TryUpdate(x, frequency + 1, frequency))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static ConcurrentDictionary<uint, uint> FrequencyCounter(this IEnumerable<uint> x)
        {
            long n = x.LongCount();

            ConcurrentDictionary<uint, uint> frequencies = new ConcurrentDictionary<uint, uint>();

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                uint x_i = x.ElementAt((int)i);

                                CalculateFrequencyAdd(frequencies, x_i);
                            }
                        );

            return frequencies;
        }

        public static void CalculateFrequencyAdd(ConcurrentDictionary<uint, uint> frequencies, uint x)
        {
            if (!frequencies.TryAdd(x, 1))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static void CalculateFrequencyUpdate(ConcurrentDictionary<uint, uint> frequencies, uint x)
        {
            uint frequency = frequencies[x];
            if (!frequencies.TryUpdate(x, frequency + 1, frequency))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static ConcurrentDictionary<long, uint> FrequencyCounter(this IEnumerable<long> x)
        {
            long n = x.LongCount();

            ConcurrentDictionary<long, uint> frequencies = new ConcurrentDictionary<long, uint>();

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                long x_i = x.ElementAt((int)i);

                                CalculateFrequencyAdd(frequencies, x_i);
                            }
                        );

            return frequencies;
        }

        public static void CalculateFrequencyAdd(ConcurrentDictionary<long, uint> frequencies, long x)
        {
            if (!frequencies.TryAdd(x, 1))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static void CalculateFrequencyUpdate(ConcurrentDictionary<long, uint> frequencies, long x)
        {
            uint frequency = frequencies[x];
            if (!frequencies.TryUpdate(x, frequency + 1, frequency))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static ConcurrentDictionary<ulong, uint> FrequencyCounter(this IEnumerable<ulong> x)
        {
            long n = x.LongCount();

            ConcurrentDictionary<ulong, uint> frequencies = new ConcurrentDictionary<ulong, uint>();

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                ulong x_i = x.ElementAt((int)i);

                                CalculateFrequencyAdd(frequencies, x_i);
                            }
                        );

            return frequencies;
        }

        public static void CalculateFrequencyAdd(ConcurrentDictionary<ulong, uint> frequencies, ulong x)
        {
            if (!frequencies.TryAdd(x, 1))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static void CalculateFrequencyUpdate(ConcurrentDictionary<ulong, uint> frequencies, ulong x)
        {
            uint frequency = frequencies[x];
            if (!frequencies.TryUpdate(x, frequency + 1, frequency))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static ConcurrentDictionary<float, uint> FrequencyCounter(this IEnumerable<float> x)
        {
            long n = x.LongCount();

            ConcurrentDictionary<float, uint> frequencies = new ConcurrentDictionary<float, uint>();

            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                float x_i = x.ElementAt((int)i);

                                CalculateFrequencyAdd(frequencies, x_i);
                            }
                        );

            return frequencies;
        }

        public static void CalculateFrequencyAdd(ConcurrentDictionary<float, uint> frequencies, float x)
        {
            if (!frequencies.TryAdd(x, 1))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static void CalculateFrequencyUpdate(ConcurrentDictionary<float, uint> frequencies, float x)
        {
            uint frequency = frequencies[x];
            if (!frequencies.TryUpdate(x, frequency + 1, frequency))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static ConcurrentDictionary<double, uint> FrequencyCounter(this IEnumerable<double> x)
        {
            long n = x.LongCount();

            ConcurrentDictionary<double, uint> frequencies = new ConcurrentDictionary<double, uint>();

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                double x_i = x.ElementAt((int)i);

                                CalculateFrequencyAdd(frequencies, x_i);
                            }
                        );

            return frequencies;
        }

        public static void CalculateFrequencyAdd(ConcurrentDictionary<double, uint> frequencies, double x)
        {
            if (!frequencies.TryAdd(x, 1))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static void CalculateFrequencyUpdate(ConcurrentDictionary<double, uint> frequencies, double x)
        {
            uint frequency = frequencies[x];
            if (!frequencies.TryUpdate(x, frequency + 1, frequency))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static ConcurrentDictionary<decimal, uint> FrequencyCounter(this IEnumerable<decimal> x)
        {
            long n = x.LongCount();

            ConcurrentDictionary<decimal, uint> frequencies = new ConcurrentDictionary<decimal, uint>();

            //for (int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For
                        (
                            0,
                            n,
                            i =>
                            {
                                decimal x_i = x.ElementAt((int)i);

                                CalculateFrequencyAdd(frequencies, x_i);
                            }
                        );

            return frequencies;
        }

        public static void CalculateFrequencyAdd(ConcurrentDictionary<decimal, uint> frequencies, decimal x)
        {
            if (!frequencies.TryAdd(x, 1))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

        public static void CalculateFrequencyUpdate(ConcurrentDictionary<decimal, uint> frequencies, decimal x)
        {
            uint frequency = frequencies[x];
            if (!frequencies.TryUpdate(x, frequency + 1, frequency))
            {
                CalculateFrequencyUpdate(frequencies, x);
            }

            return;
        }

    }
}
