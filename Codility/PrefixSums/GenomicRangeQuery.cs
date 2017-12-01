using System.Collections.Generic;
using System.Linq;

namespace Codility.PrefixSums
{
    public class GenomicRangeQuery
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        public static int[] Solution(string S, int[] P, int[] Q)
        {
            var map = new Dictionary<char, int> { { 'A', 1 }, { 'C', 2 }, { 'G', 3 }, { 'T', 4 } };
            var sums = new int[S.Length, 4];
            var genomes = S.ToCharArray();

            for (var i = 0; i < S.Length; i++)
            {
                if (i > 0)
                {
                    sums[i, 0] = sums[i - 1, 0];
                    sums[i, 1] = sums[i - 1, 1];
                    sums[i, 2] = sums[i - 1, 2];
                    sums[i, 3] = sums[i - 1, 3];
                }

                var index = map[genomes[i]] - 1;
                sums[i, index]++;
            }

            var result = new int[P.Length];
            for (var i = 0; i < P.Length; i++)
            {
                var start = P[i];
                var end = Q[i];

                //  contains A
                if ((start > 0 && sums[end, 0] - sums[start - 1, 0] > 0) || (start == 0 && sums[end, 0] > 0))
                {
                    result[i] = 1;
                    continue;
                }

                //  contains C
                if ((start > 0 && sums[end, 1] - sums[start - 1, 1] > 0) || (start == 0 && sums[end, 1] > 0))
                {
                    result[i] = 2;
                    continue;
                }

                //  contains G
                if ((start > 0 && sums[end, 2] - sums[start - 1, 2] > 0) || (start == 0 && sums[end, 2] > 0))
                {
                    result[i] = 3;
                    continue;
                }

                //  must be T
                result[i] = 4;
            }

            return result;
        }

        /// <summary>
        /// Correctness:    100%
        /// Performace:     0%
        /// Total:          62%
        /// </summary>
        /// <param name="S"></param>
        /// <param name="P"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
        public static int[] SlowSolution(string S, int[] P, int[] Q)
        {
            var map = new Dictionary<string, int> { { "A", 1 }, { "C", 2 }, { "G", 3 }, { "T", 4 } };
            var result = new int[P.Length];
            var array = S.ToCharArray().Select(a => a.ToString());


            for (var i = 0; i < P.Length; i++)
            {
                var start = P[i];
                var end = Q[i];

                var genom = array.Skip(start).Take(end - start + 1).OrderBy(a => a).First();
                result[i] = map[genom];

            }

            return result;
        }
    }
}
