using System.Linq;

namespace Codility.Sorting
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class Triangle
    {
        public static int Solution(int[] A)
        {
            if (A.Length < 3)
                return 0;

            A = A.OrderBy(a => a).ToArray();
            for (var i = 0; i < A.Length - 2; i++)
            {
                var condition1 = (long)A[i] + A[i + 1] > A[i + 2];
                var condition2 = (long)A[i] + A[i + 2] > A[i + 1];
                var condition3 = (long)A[i + 1] + A[i + 2] > A[i];

                if (condition1 && condition2 && condition3)
                    return 1;
            }

            return 0;
        }
    }
}
