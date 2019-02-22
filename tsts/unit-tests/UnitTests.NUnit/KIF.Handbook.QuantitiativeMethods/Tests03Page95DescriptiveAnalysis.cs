// /*
//    Copyright (c) 2017-12
//
//    moljac
//    Test.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */
using NUnit.Framework;
using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Parallel;

namespace UnitTests.HolisticWare.Core.Math.Statistics
{
    public partial class Tests03Page95DescriptiveAnalysis
    {
        // Arrange
        List<double> x1 = new List<double>
            {
                82.61,
                93.51,
                78.46,
                55.14,
                49.65,
                45.82,
                50.21,
                51.65,
                69.45,
                57.32,
                35.62,
                47.95,
                33.65,
                52.69,
                77.95,
            };

        [Test()]
        public void Data00()
        {
            // Act
            double x1_average = x1.Average();
            // Assert
            Assert.AreEqual(x1_average, 58.77, 0.01);

			// Act
			double x1_standard_deviation = x1.StandardDeviationSample();
            // Assert
            Assert.AreEqual(x1_standard_deviation, 17.63, 0.01);

			// Act
			double x1_min = x1.Min();
            // Assert
            Assert.AreEqual(x1_min, 33.65, 0.01);

			// Act
			double x1_max = x1.Max();
            // Assert
            Assert.AreEqual(x1_max, 93.51, 0.01);

            return;
        }

        // Arrange
        List<double> x21 = new List<double>
            {
                87.61,
                98.51,
                83.46,
                60.14,
                54.65,
                50.82,
                55.21,
                56.65,
                74.45,
                62.32,
                40.62,
                52.95,
                38.65,
                57.69,
                82.95,
            };

        [Test()]
        public void Data01()
        {
            // Act
            double x21_average = x21.Average();
            // Assert
            Assert.AreEqual(x21_average, 63.77, 0.01);

            // Act
            double x21_standard_deviation = x21.StandardDeviationSample();
            // Assert
            Assert.AreEqual(x21_standard_deviation, 17.63, 0.01);

            // Act
            double x21_min = x21.Min();
            // Assert
            Assert.AreEqual(x21_min, 38.65, 0.01);

            // Act
            double x21_max = x21.Max();
            // Assert
            Assert.AreEqual(x21_max, 98.51, 0.01);

            // Arrange
            List<double> d1 = new List<double>();
            for(int i = 0; i < x1.Count; i++)
            {
                d1.Add(x21[i] - x1[i]);
            }

            // Act
            double d1_average = d1.Average();
            // Assert
            Assert.AreEqual(d1_average, 5.0, 0.01);

            // Act
            double d1_min = d1.Min();
            // Assert
            Assert.AreEqual(d1_min, 5.0, 0.01);

            // Act
            double d1_max = d1.Max();
            // Assert
            Assert.AreEqual(d1_max, 5.0, 0.01);

            //var d1_range = d1.Range();
            //Assert.AreEqual(d1_max, 93.51, 0.01);
            //Assert.AreEqual(d1_max, 93.51, 0.01);

            // Act
            double d1_standard_deviation_sample = d1.StandardDeviationSample();
            // Assert
            Assert.AreEqual(d1_standard_deviation_sample, 0.0, 0.01);

            // Act
            double d1_standard_deviation_population = d1.StandardDeviationPopulation();
            // Assert
            Assert.AreEqual(d1_standard_deviation_population, 0.0, 0.01);

            return;
        }

        // Arrange
        List<double> x22 = new List<double>
            {
                83.98,
                94.31,
                80.62,
                56.36,
                57.47,
                51.19,
                56.54,
                60.91,
                74.45,
                67.00,
                44.56,
                53.24,
                39.51,
                57.64,
                80.21,
            };

        [Test()]
        public void Data02()
        {
            // Act
            double x22_average = x22.Average();
            double x22_standard_deviation = x22.StandardDeviationSample();
            double x22_min = x22.Min();
            double x22_max = x22.Max();

            // Assert
            Assert.AreEqual(x22_average, 63.86, 0.01);
            Assert.AreEqual(x22_standard_deviation, 15.67, 0.01);
            Assert.AreEqual(x22_min, 39.51, 0.01);
            Assert.AreEqual(x22_max, 94.31, 0.01);

            // Arrange
            List<double> d2 = new List<double>();
            for (int i = 0; i < x1.Count; i++)
            {
                d2.Add(x22[i] - x1[i]);
            }

            // Act
            double d2_average = d2.Average();
            double d2_min = d2.Min();
            double d2_max = d2.Max();
            double d2_standard_deviation = d2.StandardDeviationSample();

            // Assert
            Assert.AreEqual(d2_average, 5.08, 0.01);
            Assert.AreEqual(d2_min, 0.8, 0.01);
            Assert.AreEqual(d2_max, 9.68, 0.01);
            Assert.AreEqual(d2_standard_deviation, 3.01, 0.01);

            return;
        }

        // Arrange
        List<double> x23 = new List<double>
            {
                85.65,
                94.62,
                83.65,
                59.84,
                52.34,
                51.26,
                61.24,
                57.95,
                80.65,
                61.53,
                37.45,
                58.31,
                33.95,
                64.25,
                82.21,
            };

        [Test()]
        public void Data03()
        {
            // Act
            double x23_average = x23.Average();
            Assert.AreEqual(x23_average, 64.32, 0.01);

            // Act
            double x23_standard_deviation = x23.StandardDeviationSample();
            Assert.AreEqual(x23_standard_deviation, 17.73, 0.01);

            // Act
            double x23_min = x23.Min();
            Assert.AreEqual(x23_min, 33.95, 0.01);

            // Act
            double x23_max = x23.Max();
            Assert.AreEqual(x23_max, 94.62, 0.01);

            // Arrange
            List<double> d3 = new List<double>();
            for (int i = 0; i < x1.Count; i++)
            {
                d3.Add(x23[i] - x1[i]);
            }

            // Act
            double d3_average = d3.Average();
            Assert.AreEqual(d3_average, 5.54, 0.01);

            // Act
            double d3_min = d3.Min();
            Assert.AreEqual(d3_min, 0.3, 0.01);

            // Act
            double d3_max = d3.Max();
            Assert.AreEqual(d3_max, 11.56, 0.01);

            // Act
            double d3_standard_deviation = d3.StandardDeviationSample();
            Assert.AreEqual(d3_standard_deviation, 3.79, 0.01);


            return;
        }

    }
}
