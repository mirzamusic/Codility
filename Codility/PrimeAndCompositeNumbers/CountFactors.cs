using System;

namespace Codility.PrimeAndCompositeNumbers
{
    public class CountFactors
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        public static int Solution(int N)
        {
            var factors = 0;
            var sqrt = Math.Sqrt(N);
            for (var i = 1; i <= sqrt; i++)
            {
                if (N % i != 0)
                    continue;

                if (N / i == i)
                {
                    factors++;
                    continue;
                }

                factors += 2;
            }

            return factors;
        }
    }
}
