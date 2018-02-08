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
    public partial class Tests20180119
    {
        
        [Test()]
        public void Frequencies01()
        {
            List<int> data01 = new List<int> { 1, 2, 2, 3, 3, 3, 3, 4, 4, 5 };

            IEnumerable<KeyValuePair<int, uint>> frequencies01 = data01.Frequencies();

            Assert.AreEqual
                        (
                            new Dictionary<int, uint> 
                                        {
                                            { 3, 4 },
                                            { 2, 2 },
                                            { 4, 2 },
                                            { 1, 1 },
                                            { 5, 1 },                            
                                        }
                                .ToList(), 
                            frequencies01
                        );

            return;
        }

        [Test()]
        public void Frequencies02()
        {
            // Arrange
            Stack<double> data01 =
                new Stack<double>
                        (
                            new[]
                            {
                                25.4, 14.7, 16.4, 15.3, 17.4, 15.0, 15.0, 19.4, 17.5, 14.7,
                                18.0, 15.2, 16.0, 13.7, 18.2, 15.9, 14.7, 13.3, 15.1, 17.6,
                                16.1, 12.9, 12.2, 12.7, 16.2, 13.5, 11.8, 11.7, 13.4, 17.0,
                                17.1, 13.8, 15.5, 19.3, 16.2, 16.9, 12.1, 16.8, 11.6, 13.0,
                                12.9, 10.5, 11.3, 14.3, 19.5, 18.6, 18.6, 22.9, 19.8, 13.4,
                                18.2, 14.5, 24.0, 16.5, 16.4, 28.9, 13.5, 13.6, 11.9, 18.2,
                            }
                        );

            // Act
            IEnumerable<KeyValuePair<double, uint>> frequencies01 = data01.Frequencies();

            // Assert
            Assert.AreEqual
                        (
                            new Dictionary<double, uint>
                                {                
                                    { 18.2, 3 },
                                    { 14.7, 3 },
                                    { 13.5, 2 },
                                    { 16.4, 2 },
                                    { 13.4, 2 },
                                    { 18.6, 2 },
                                    { 12.9, 2 },
                                    { 16.2, 2 },
                                    { 15, 2 },
                                    { 11.9, 1 },
                                    { 13.6, 1 },
                                    { 28.9, 1 },
                                    { 16.5, 1 },
                                    { 24, 1 },
                                    { 14.5, 1 },
                                    { 19.8, 1 },
                                    { 22.9, 1 },
                                    { 19.5, 1 },
                                    { 14.3, 1 },
                                    { 11.3, 1 },
                                    { 10.5, 1 },
                                    { 13, 1 },
                                    { 11.6, 1 },
                                    { 16.8, 1 },
                                    { 12.1, 1 },
                                    { 16.9, 1 },
                                    { 19.3, 1 },
                                    { 15.5, 1 },
                                    { 13.8, 1 },
                                    { 17.1, 1 },
                                    { 17, 1 },
                                    { 11.7, 1 },
                                    { 11.8, 1 },
                                    { 12.7, 1 },
                                    { 12.2, 1 },
                                    { 16.1, 1 },
                                    { 17.6, 1 },
                                    { 15.1, 1 },
                                    { 13.3, 1 },
                                    { 15.9, 1 },
                                    { 13.7, 1 },
                                    { 16, 1 },
                                    { 15.2, 1 },
                                    { 18, 1 },
                                    { 17.5, 1 },
                                    { 19.4, 1 },
                                    { 17.4, 1 },
                                    { 15.3, 1 },
                                    { 25.4, 1 },
                                }.ToList(),
                            frequencies01
                        );

            return;
        }

        [Test()]
        public void Frequencies03()
        {
            // Arange
            Queue<int> data01 = 
                new Queue<int> 
                        (
                            new[]
                            {
                                160, 135, 175, 170, 155, 170, 165, 150, 155, 195,
                                175, 150, 180, 210, 180, 205, 180, 160, 170, 185,
                                160, 195, 190, 205, 160, 185, 180, 205, 195, 180,
                                160, 170, 155, 150, 195, 175, 175, 190, 185, 180,
                                180, 190, 195, 175, 175, 175, 175, 150, 165, 180, 
                                165, 195, 200, 190, 190, 165, 170, 205, 200, 180,
                            }
                        );

            // Act
            IEnumerable<KeyValuePair<int, uint>> frequencies01 = data01.Frequencies();

            // Assert
            Assert.AreEqual
                        (
                            new Dictionary<int, uint>
                                {
                                    { 180, 9 },
                                    { 175, 8 },
                                    { 195, 6 },
                                    { 160, 5 },
                                    { 170, 5 },
                                    { 190, 5 },
                                    { 165, 4 },
                                    { 150, 4 },
                                    { 205, 4 },
                                    { 155, 3 },
                                    { 185, 3 },
                                    { 200, 2 },
                                    { 135, 1 },
                                    { 210, 1 },
                                }.ToList(),
                            frequencies01   
                        );

            return;
        }
    }
}
