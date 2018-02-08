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
using System.Collections;

namespace UnitTests.HolisticWare.Core.Math.Statistics
{
    public partial class Tests03Mode
    {

        [Test()]
        public void Mode01()
        {
            List<int> data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            List<int> modes01 = data01.Modes();

            Assert.AreEqual(new List<int> { 4 }, modes01);


            Stack<int> data02 = new Stack<int>(new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 });

            List<int> modes02 = data02.Modes();

            Assert.AreEqual(new List<int> { 4 }, modes02);


            Queue<int> data03 = new Queue<int>(new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 });

            List<int> modes03 = data03.Modes();

            Assert.AreEqual(new List<int> { 4 }, modes03);


            int[] data04 = new[] { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            List<int> modes04 = data04.Modes();

            Assert.AreEqual(new List<int> { 4 }, modes04);

            ArrayList data05 = new ArrayList { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            #if NETSTANDARD1_3
            List<int> modes05 = data05.Modes();

            Assert.AreEqual(new List<int> { 4 }, modes05);
            #endif

            return;
        }

        [Test()]
        public void Mode02()
        {
            List<int> data01 = new List<int> { 1, 2, 2, 3, 3, 4 };

            List<int> modes01 = data01.Modes();

            Assert.AreEqual(new List<int> { 2, 3 }, modes01);

            return;
        }

        [Test()]
        public void Mode03()
        {
            List<int> data01 = new List<int> { 1, 2, 2, 3, 3, 4, 5, 6 };

            List<int> modes01 = data01.Modes();

            Assert.AreEqual(new List<int> { 2, 3 }, modes01);

            return;
        }
    }
}
