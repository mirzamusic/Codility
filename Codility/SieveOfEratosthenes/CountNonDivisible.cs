namespace Codility.SieveOfEratosthenes
{
    public class CountNonDivisible
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     0%
        /// Overall:        55%
        /// </summary>
        public static int[] Solution(int[] A)
        {
            if (A.Length <= 1)
                return new[] { 0 };

            var results = new int[A.Length];

            for (var i = 0; i < A.Length; i++)
                foreach (var item in A)
                {
                    if (item == 1 || item == A[i])
                        continue;

                    if (A[i] % item != 0)
                        results[i]++;
                }

            return results;
        }
    }
}
