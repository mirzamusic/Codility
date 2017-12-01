using System.Linq;

namespace Codility.CountingElements
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class PermCheck
    {
        public static int Solution(int[] A)
        {
            var ordered = A.OrderBy(a => a).ToArray();
            for (var i = 0; i < A.Length; i++)
            {
                if (ordered[i] == i + 1)
                    continue;

                return 0;
            }

            return 1;
        }
    }
}
