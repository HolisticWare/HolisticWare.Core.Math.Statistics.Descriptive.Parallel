using System;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive.Sequential;


namespace Core.Math.Statistics.Descriptive.Sequential
{
    /// <summary>
    /// </summary>
    public static partial class IEnumerableExtensionsModes
    {
        #if NETSTANDARD1_3
        [Obsolete("Performance issue (boxing)")]
        public static System.Collections.ArrayList Modes(this System.Collections.ArrayList x)
        {
            IEnumerable<KeyValuePair<object, uint>> frequencies = x.Frequencies();

            System.Collections.ArrayList modes = new System.Collections.ArrayList();

            uint occurences = ((KeyValuePair<object, uint>)frequencies?.ElementAt(0)).Value;

            foreach (KeyValuePair<object, uint> kvp in frequencies)
            {
                if (occurences == kvp.Value)
                {
                    modes.Add(kvp.Key);
                }
            }

            return modes;
        }
        #endif

    }
}
