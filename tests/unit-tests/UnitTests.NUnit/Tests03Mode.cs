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
using System.Collections;
using System.Diagnostics;


using Core.Math.Statistics.Descriptive.Parallel;

namespace UnitTests.HolisticWare.Core.Math.Statistics
{
    public partial class Tests03Mode
    {
        Stopwatch sw = null;

        [Test()]
        public void Mode01()
        {
            //====================================================================================================
            // Arrange
            List<int> data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes01 = data01.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.Average() size={data01.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            // Assert
            Assert.AreEqual(new List<int> { 4 }, modes01);
            //====================================================================================================

            //====================================================================================================
            // Arrange
            Stack<int> data02 = new Stack<int>(new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 });

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes02 = data02.Modes();
            sw.Stop();
            Console.WriteLine($"Stack<int>.Average() size={data02.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            // Assert
            Assert.AreEqual(new List<int> { 4 }, modes02);
            //====================================================================================================

            //====================================================================================================
            // Arrange
            Queue<int> data03 = new Queue<int>(new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 });

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes03 = data03.Modes();
            sw.Stop();
            Console.WriteLine($"Queue<int>.Average() size={data03.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            // Assert
            Assert.AreEqual(new List<int> { 4 }, modes03);
            //====================================================================================================

            //====================================================================================================
            // Arrange
            int[] data04 = new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes04 = data04.Modes();
            sw.Stop();
            Console.WriteLine($"int[].Modes() size={data04.Length} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            // Assert
            Assert.AreEqual(new List<int> { 4 }, modes04);
            //====================================================================================================

            #if NETSTANDARD1_3
            //====================================================================================================
            // Arrange
            ArrayList data05 = new ArrayList { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes05 = data05.Modes();
            sw.Stop();
            Console.WriteLine($"ArrayList.Modes() size={data05.Count} elapsed[ticks]={sw.ElapsedTicks}");
            sw.Reset();

            // Assert
            Assert.AreEqual(new List<int> { 4 }, modes05);
            //====================================================================================================
            #endif

            return;
        }

        [Test()]
        public void Mode02()
        {
            //====================================================================================================
            // Arrange
            List<int> data01 = new List<int> { 1, 2, 2, 3, 3, 4 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes01 = data01.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.Modes() size={data01.Count} elapsed[ticks]={sw.ElapsedTicks}");

            // Assert
            Assert.AreEqual(new List<int> { 2, 3 }, modes01);
            //====================================================================================================

            return;
        }

        [Test()]
        public void Mode03()
        {
            //====================================================================================================
            // Arrange
            List<int> data01 = new List<int> { 1, 2, 2, 3, 3, 4, 5, 6 };

            sw = Stopwatch.StartNew();
            // Act
            List<int> modes01 = data01.Modes();
            sw.Stop();
            Console.WriteLine($"List<int>.Modes() size={data01.Count} elapsed[ticks]={sw.ElapsedTicks}");

            // Assert
            Assert.AreEqual(new List<int> { 2, 3 }, modes01);
            //====================================================================================================

            return;
        }
    }
}
