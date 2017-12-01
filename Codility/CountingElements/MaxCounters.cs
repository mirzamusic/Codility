using System;
using System.Linq;

namespace Codility.CountingElements
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class MaxCounters
    {
        public static int[] Solution(int N, int[] A)
        {
            var counters = new int[N];
            var upAll = 0;
            var currentMax = 0;

            foreach (var operation in A)
            {
                if (operation > counters.Length || operation - 1 < 0)
                {
                    upAll = currentMax;
                    continue;
                }

                if (counters[operation - 1] < upAll)
                    counters[operation - 1] = upAll;

                counters[operation - 1]++;
                currentMax = currentMax < counters[operation - 1] ? counters[operation - 1] : currentMax;
            }

            for (var i = 0; i < counters.Length; i++)
            {
                if (counters[i] < upAll)
                    counters[i] = upAll;
            }

            return counters;
        }
    }
}
