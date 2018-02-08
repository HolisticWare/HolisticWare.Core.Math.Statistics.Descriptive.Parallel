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
    public partial class Tests02Frequencies
    {
        
        [Test()]
        public void Frequencies()
        {
            List<int> data01 = new List<int> { 2, 4, 3, 5, 6, 7, 4, 4, 2, 1 };

            IEnumerable<KeyValuePair<int, uint>> frequencies01 = data01.Frequencies();

            CollectionAssert.AreEquivalent
                                (
                                    frequencies01,
                                    new Dictionary<int, uint>()
                                    {
                                        { 4, 3 },
                                        { 2, 2 },
                                        { 3, 1 },
                                        { 5, 1 },
                                        { 6, 1 },
                                        { 7, 1 },
                                        { 1, 1 },
                                    }
                                );
            return;
        }

    }
}
