using System.Linq;

namespace Codility.MaximumSliceProblem
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class MaxProfit
    {
        public static int Solution(int[] A)
        {
            if (A.Length == 0)
                return 0;

            var difs = new int[A.Length];
            difs[0] = int.MinValue;

            for (var i = 1; i < A.Length; i++)
            {
                difs[i] = A[i] - A[i - 1];
            }

            var maxEnd = 0;
            var maxSlice = 0;

            foreach (var a in difs)
            {
                maxEnd = new[] { 0, maxEnd + a }.Max();
                maxSlice = new[] { maxSlice, maxEnd }.Max();
            }

            return maxSlice;
        }
    }
}
