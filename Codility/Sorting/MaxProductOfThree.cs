using System.Linq;

namespace Codility.Sorting
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class MaxProductOfThree
    {
        public static int Solution(int[] A)
        {
            var length = A.Length;
            A = A.OrderBy(a => a).ToArray();

            var result = A[length - 1] * A[length - 2] * A[length - 3];
            if (A[0] * A[1] <= 0 || A[0] >= 0)
                return result;

            var otherSide = A[0] * A[1] * A[length - 1];
            return otherSide > result ? otherSide : result;
        }
    }
}
