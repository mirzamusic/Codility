using System;

namespace Codility.MaximumSliceProblem
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class MaxDoubleSliceSum
    {
        public static int Solution(int[] numbers)
        {
            var fromLeft = new int[numbers.Length];
            for (var i = 1; i < numbers.Length - 1; i++)
                fromLeft[i] = Math.Max(0, fromLeft[i - 1] + numbers[i]);

            var fromRight = new int[numbers.Length];
            for (var i = numbers.Length - 2; i > 0; i--)
                fromRight[i] = Math.Max(0, fromRight[i + 1] + numbers[i]);

            var max = 0;
            for (var i = 1; i < numbers.Length - 1; i++)
                max = Math.Max(max, fromLeft[i - 1] + fromRight[i + 1]);

            return max;
        }
    }
}