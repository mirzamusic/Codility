namespace Codility.EuclideanAlgorithm
{
    public class ChocolatesByNumbers
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        public static int Solution(int N, int M)
        {
            return N / GetGreatestCommonDivisor(N, M);
        }

        private static int GetGreatestCommonDivisor(int a, int b)
        {
            if (a % b == 0)
                return b;

            return GetGreatestCommonDivisor(b, a % b);
        }
    }
}
