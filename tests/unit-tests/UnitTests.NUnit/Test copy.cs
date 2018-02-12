using System;
using System.Collections.Generic;
using System.Linq;

namespace HolisticWare.Core.Math.Statistics
{
    public class Test
    {
        public Test()
        {
            List<uint> nina_hrvatski_ocjene = new List<uint>
            {
                5,
                5,
                5,
                5,
                4,
                5,
                5,
            };

            var nina_hrvatski_prosjek = nina_hrvatski_ocjene.Cast<int>().Average();        
        }
    }
}
