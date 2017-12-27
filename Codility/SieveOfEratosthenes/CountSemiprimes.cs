using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.SieveOfEratosthenes
{
    public class CountSemiprimes
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        public static int[] Solution(int N, int[] P, int[] Q)
        {
            var all = Enumerable.Repeat(true, N + 1).ToArray();
            var root = Math.Sqrt(N);

            all[0] = false;
            all[1] = false;
            for (var i = 2; i < root; i++)
            {
                if (!all[i])
                    continue;

                var j = i * i;
                while (j <= N)
                {
                    all[j] = false;
                    j += i;
                }
            }

            // get primes
            var primes = new List<int>();
            for (var i = 0; i < all.Length; i++)
            {
                if (all[i])
                    primes.Add(i);
            }

            // calculate semiprimes
            var semiPrimes = new int[N + 1];
            for (var i = 0; i <= root; i++)
                for (var j = i; j < primes.Count; j++)
                {
                    var semiPrime = primes[i] * primes[j];
                    if (semiPrime > N)
                        break;

                    semiPrimes[semiPrime] = 1;
                }

            // calculate prefix sums
            var semiPrimesCount = new int[N + 1];
            for (var i = 1; i < semiPrimesCount.Length; i++)
            {
                semiPrimesCount[i] = semiPrimesCount[i - 1] + semiPrimes[i];
            }

            // calculate the result
            var result = new List<int>();
            for (var i = 0; i < P.Length; i++)
                result.Add(semiPrimesCount[Q[i]] - semiPrimesCount[P[i] - 1]);

            return result.ToArray();
        }
    }
}
