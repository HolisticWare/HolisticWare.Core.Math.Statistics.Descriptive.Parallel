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

                            correlation =
                                (n * sum_product_x_y - sum_x * sum_y)
                                /
                                (
                                    System.Math.Sqrt((n * sum_x_pow_2) - sum_x * sum_x)
                                    *
                                    System.Math.Sqrt((n * sum_y_pow_2) - sum_y * sum_y)
                                )
                                ;
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

                            correlation =
                                (n * sum_product_x_y - sum_x * sum_y)
                                /
                                (
                                    System.Math.Sqrt((n * sum_x_pow_2) - sum_x * sum_x)
                                    *
                                    System.Math.Sqrt((n * sum_y_pow_2) - sum_y * sum_y)
                                )
                                ;
                        }
               );

            return correlation;
        }

    }
}
