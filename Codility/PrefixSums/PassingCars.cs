namespace Codility.PrefixSums
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class PassingCars
    {
        public static int Solution(int[] A)
        {
            if (A.Length > 100000)
                return -1;

            var sums = new int[A.Length];
            var goingEast = 0;

            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] != 0 && A[i] != 1)
                    return -1;

                if (A[i] == 0)
                {
                    goingEast++;
                    sums[i] = i == 0 ? 0 : sums[i - 1];
                    continue;
                }

                sums[i] = i == 0 ? 0 : sums[i - 1] + goingEast;
                if (sums[i] > 1000000000)
                    return -1;
            }

            return sums[sums.Length - 1];
        }
    }
}
