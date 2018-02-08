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

using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics;

namespace UnitTests.HolisticWare.Core.Math.Statistics
{
    public partial class My_UT
    {
        [Test()]
        public void Data04()
        {
            // Arrange
            List<double> x4 = new List<double>
            {
                25.4, 14.7, 16.4, 15.3, 17.4, 15.0, 15.0, 19.4, 17.5, 14.7,
                18.0, 15.2, 16.0, 13.7, 18.2, 15.9, 14.7, 13.3, 15.1, 17.6,
                16.1, 12.9, 12.2, 12.7, 16.2, 13.5, 11.8, 11.7, 13.4, 17.0,
                17.1, 13.8, 15.5, 19.3, 16.2, 16.9, 12.1, 16.8, 11.6, 13.0,
                12.9, 10.5, 11.3, 14.3, 19.5, 18.6, 18.6, 22.9, 19.8, 13.4,
                18.2, 14.5, 24.0, 16.5, 16.4, 28.9, 13.5, 13.6, 11.9, 18.2,
            };

            // Act
            double x4_average = x4.Average();
            // Assert
            Assert.AreEqual(x4_average, 15.93, 0.01);

            // Act
            double x4_standard_deviation = x4.StandardDeviationSample();
            // Assert
            Assert.AreEqual(x4_standard_deviation, 3.48, 0.01);

            // Act
            double x4_min = x4.Min();
            // Assert
            Assert.AreEqual(x4_min, 10.5, 0.01);

            // Act
            double x4_max = x4.Max();
            // Assert
            Assert.AreEqual(x4_max, 28.9, 0.01);

            return;
        }        
    }
}
