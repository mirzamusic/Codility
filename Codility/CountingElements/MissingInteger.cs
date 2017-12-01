using System.Linq;

namespace Codility.CountingElements
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class MissingInteger
    {
        public static int Solution(int[] A)
        {
            var max = A.Max();
            if (max <= 0)
                return 1;

            var counts = new int[max + 2];
            foreach (var value in A)
            {
                if (value <= 0)
                    continue;

                counts[value]++;
            }

            for (var i = 1; i < counts.Length; i++)
            {
                if (counts[i] == 0)
                    return i;
            }

            return -1;
        }
    }
}
