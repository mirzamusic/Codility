using System;

namespace Codility.MaximumSliceProblem
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class MaxSliceSum
    {
        public static int Solution(int[] A)
        {
            var maxEnd = A[0];
            var maxSlice = A[0];
            for (var i = 1; i < A.Length; i++)
            {
                maxEnd = Math.Max(A[i], maxEnd + A[i]);
                maxSlice = Math.Max(maxSlice, maxEnd);
            }

            return maxSlice;
        }
    }
}
