using System;

namespace Codility.PrimeAndCompositeNumbers
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class MinPerimeterRectangle
    {
        public static int Solution(int N)
        {
            var min = int.MaxValue;
            for (var i = 1; i * i <= N; i++)
                if (N % i == 0)
                    min = Math.Min(2 * (N / i + i), min);

            return min;
        }
    }
}
