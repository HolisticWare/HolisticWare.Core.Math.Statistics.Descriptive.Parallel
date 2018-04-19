using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;


namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// </summary>
    public static partial class IEnumerableExtensionsCorrelationOptimized
    {
        public static double CorrelationOptimized(this IEnumerable<short> x, IEnumerable<short> y)
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            double correlation = double.NaN;
            //for(int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For

                    (
                        0,
                        n,
                        i =>
                        {
                            short x_i = x.ElementAt(i);
                            short y_i = y.ElementAt(i);

                            sum_x += x_i;
                            sum_y += y_i;
                            sum_x_pow_2 += x_i * x_i;
                            sum_y_pow_2 += y_i * y_i;
                            sum_product_x_y += x_i * y_i;

                            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
                            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
                            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

                            if (System.Math.Abs(denominator) < Double.Epsilon)
                            {
                                correlation =  0.0;
                            }
                            else
                            {
                                correlation =
                                                (n * sum_product_x_y - sum_x * sum_y)
                                                /
                                                denominator
                                                ;                    
                            }
                        }
               );

            return correlation;
        }

        public static double CorrelationOptimized(this IEnumerable<ushort> x, IEnumerable<ushort> y)
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            double correlation = double.NaN;
            //for(int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For

                    (
                        0,
                        n,
                        i =>
                        {
                            ushort x_i = x.ElementAt(i);
                            ushort y_i = y.ElementAt(i);

                            sum_x += x_i;
                            sum_y += y_i;
                            sum_x_pow_2 += x_i * x_i;
                            sum_y_pow_2 += y_i * y_i;
                            sum_product_x_y += x_i * y_i;

                            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
                            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
                            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

                            if (System.Math.Abs(denominator) < Double.Epsilon)
                            {
                                correlation = 0.0;
                            }
                            else
                            {
                                correlation =
                                                (n * sum_product_x_y - sum_x * sum_y)
                                                /
                                                denominator
                                                ;
                            }
                        }
               );

            return correlation;
        }

        public static double CorrelationOptimized(this IEnumerable<int> x, IEnumerable<int> y)
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            double correlation = double.NaN;
            //for(int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For

                    (
                        0,
                        n,
                        i =>
                        {
                            int x_i = x.ElementAt(i);
                            int y_i = y.ElementAt(i);

                            sum_x += x_i;
                            sum_y += y_i;
                            sum_x_pow_2 += x_i * x_i;
                            sum_y_pow_2 += y_i * y_i;
                            sum_product_x_y += x_i * y_i;

                            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
                            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
                            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

                            if (System.Math.Abs(denominator) < Double.Epsilon)
                            {
                                correlation = 0.0;
                            }
                            else
                            {
                                correlation =
                                                (n * sum_product_x_y - sum_x * sum_y)
                                                /
                                                denominator
                                                ;
                            }
                        }
               );

            return correlation;
        }

        public static double CorrelationOptimized(this IEnumerable<uint> x, IEnumerable<uint> y)
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            double correlation = double.NaN;
            //for(int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For

                    (
                        0,
                        n,
                        i =>
                        {
                            uint x_i = x.ElementAt(i);
                            uint y_i = y.ElementAt(i);

                            sum_x += x_i;
                            sum_y += y_i;
                            sum_x_pow_2 += x_i * x_i;
                            sum_y_pow_2 += y_i * y_i;
                            sum_product_x_y += x_i * y_i;

                            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
                            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
                            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

                            if (System.Math.Abs(denominator) < Double.Epsilon)
                            {
                                correlation = 0.0;
                            }
                            else
                            {
                                correlation =
                                                (n * sum_product_x_y - sum_x * sum_y)
                                                /
                                                denominator
                                                ;
                            }
                        }
               );

            return correlation;
        }

        public static double CorrelationOptimized(this IEnumerable<long> x, IEnumerable<long> y)
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            double correlation = double.NaN;
            //for(int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For

                    (
                        0,
                        n,
                        i =>
                        {
                            long x_i = x.ElementAt(i);
                            long y_i = y.ElementAt(i);

                            sum_x += x_i;
                            sum_y += y_i;
                            sum_x_pow_2 += x_i * x_i;
                            sum_y_pow_2 += y_i * y_i;
                            sum_product_x_y += x_i * y_i;

                            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
                            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
                            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

                            if (System.Math.Abs(denominator) < Double.Epsilon)
                            {
                                correlation = 0.0;
                            }
                            else
                            {
                                correlation =
                                                (n * sum_product_x_y - sum_x * sum_y)
                                                /
                                                denominator
                                                ;
                            }
                        }
               );

            return correlation;
        }

        public static double CorrelationOptimized(this IEnumerable<ulong> x, IEnumerable<ulong> y)
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            double correlation = double.NaN;
            //for(int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For

                    (
                        0,
                        n,
                        i =>
                        {
                            ulong x_i = x.ElementAt(i);
                            ulong y_i = y.ElementAt(i);

                            sum_x += x_i;
                            sum_y += y_i;
                            sum_x_pow_2 += x_i * x_i;
                            sum_y_pow_2 += y_i * y_i;
                            sum_product_x_y += x_i * y_i;

                            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
                            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
                            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

                            if (System.Math.Abs(denominator) < Double.Epsilon)
                            {
                                correlation = 0.0;
                            }
                            else
                            {
                                correlation =
                                                (n * sum_product_x_y - sum_x * sum_y)
                                                /
                                                denominator
                                                ;
                            }
                        }
               );

            return correlation;
        }

        public static double CorrelationOptimized(this IEnumerable<float> x, IEnumerable<float> y)
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            double correlation = double.NaN;
            //for(int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For

                    (
                        0,
                        n,
                        i =>
                        {
                            float x_i = x.ElementAt(i);
                            float y_i = y.ElementAt(i);

                            sum_x += x_i;
                            sum_y += y_i;
                            sum_x_pow_2 += x_i * x_i;
                            sum_y_pow_2 += y_i * y_i;
                            sum_product_x_y += x_i * y_i;

                            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
                            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
                            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

                            if (System.Math.Abs(denominator) < Double.Epsilon)
                            {
                                correlation = 0.0;
                            }
                            else
                            {
                                correlation =
                                                (n * sum_product_x_y - sum_x * sum_y)
                                                /
                                                denominator
                                                ;
                            }
                        }
               );

            return correlation;
        }

        public static double CorrelationOptimized(this IEnumerable<double> x, IEnumerable<double> y)
        {
            int n = x.Count();

            double sum_x = 0.0;
            double sum_y = 0.0;
            double sum_x_pow_2 = 0.0;
            double sum_y_pow_2 = 0.0;
            double sum_product_x_y = 0.0;

            double correlation = double.NaN;
            //for(int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For

                    (
                        0,
                        n,
                        i =>
                        {
                            double x_i = x.ElementAt(i);
                            double y_i = y.ElementAt(i);

                            sum_x += x_i;
                            sum_y += y_i;
                            sum_x_pow_2 += x_i * x_i;
                            sum_y_pow_2 += y_i * y_i;
                            sum_product_x_y += x_i * y_i;

                            double tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
                            double tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
                            double denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

                            if (System.Math.Abs(denominator) < Double.Epsilon)
                            {
                                correlation = 0.0;
                            }
                            else
                            {
                                correlation =
                                                (n * sum_product_x_y - sum_x * sum_y)
                                                /
                                                denominator
                                                ;
                            }
                        }
               );

            return correlation;
        }

        public static decimal CorrelationOptimized(this IEnumerable<decimal> x, IEnumerable<decimal> y)
        {
            int n = x.Count();

            decimal sum_x = 0.0;
            decimal sum_y = 0.0;
            decimal sum_x_pow_2 = 0.0;
            decimal sum_y_pow_2 = 0.0;
            decimal sum_product_x_y = 0.0;

            decimal? correlation;
            //for(int i = 0; i < n; i++)
            System.Threading.Tasks.Parallel.For

                    (
                        0,
                        n,
                        i =>
                        {
                            decimal x_i = x.ElementAt(i);
                            decimal y_i = y.ElementAt(i);

                            sum_x += x_i;
                            sum_y += y_i;
                            sum_x_pow_2 += x_i * x_i;
                            sum_y_pow_2 += y_i * y_i;
                            sum_product_x_y += x_i * y_i;

                            decimal tmp_x = n * sum_x_pow_2 - sum_x * sum_x;
                            decimal tmp_y = n * sum_y_pow_2 - sum_y * sum_y;
                            decimal denominator = System.Math.Sqrt(tmp_x) * System.Math.Sqrt(tmp_y);

                            if (denominator == decimal.Zero)
                            {
                                correlation = 0.0M;
                            }
                            else
                            {
                                correlation =
                                                (n * sum_product_x_y - sum_x * sum_y)
                                                /
                                                denominator
                                                ;
                            }
                        }
               );

            return correlation;
        }

    }
}
