namespace Codility.Sorting
{
    public class NumberOfDiscIntersections
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        public static int Solution(int[] A)
        {
            var l = A.Length;
            var result = 0;
            var dps = new int[l];
            var dpe = new int[l];

            for (int i = 0, t = l - 1; i < l; i++)
            {
                var s = i > A[i] ? i - A[i] : 0;
                var e = t - i > A[i] ? i + A[i] : t;
                dps[s]++;
                dpe[e]++;
            }

            for (int i = 0, t = 0; i < l; i++)
            {
                if (dps[i] > 0)
                {
                    result += t * dps[i];
                    result += dps[i] * (dps[i] - 1) / 2;

                    if (10000000 < result)
                        return -1;

                    t += dps[i];
                }
                t -= dpe[i];
            }

            return result;
        }
    }
}
