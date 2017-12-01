using System.Linq;

namespace Codility.Arrays
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class OddOccurrencesInArray
    {
        public static int Solution(int[] A)
        {
            var sorted = A.OrderBy(item => item).ToArray();
            if (sorted.Length == 1)
                return sorted[0];

            for (var i = 0; i < sorted.Length; i++)
            {
                if (i == sorted.Length - 1 || i % 2 == 0 && sorted[i] != sorted[i + 1])
                    return sorted[i];
            }

            return 0;
        }
    }
}
