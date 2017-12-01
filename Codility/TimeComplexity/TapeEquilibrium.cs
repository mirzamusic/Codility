using System;

namespace Codility.TimeComplexity
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            var result = int.MaxValue;
            var sums = new int[A.Length];
            for (var i = 0; i < A.Length; i++)
                sums[i] = i == 0 ? A[i] : sums[i - 1] + A[i];

            for (var i = 1; i < A.Length; i++)
            {
                var currentDifference = Math.Abs(sums[A.Length - 1] - 2 * sums[i - 1]);
                result = result > currentDifference ? currentDifference : result;
            }

            return result;
        }
    }
}
