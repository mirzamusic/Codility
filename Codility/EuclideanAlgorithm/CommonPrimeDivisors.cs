namespace Codility.EuclideanAlgorithm
{
    public class CommonPrimeDivisors
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        public static int Solution(int[] A, int[] B)
        {
            var result = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (HasSamePrimeDivisors(A[i], B[i]))
                    result++;
            }

            return result;
        }

        private static bool HasSamePrimeDivisors(int x, int y)
        {
            var gcd = GetGreatestCommonDivisor(x, y);

            x = removeCommonPrimeDivisors(x, gcd);
            if (x != 1)
                return false;

            return removeCommonPrimeDivisors(y, gcd) == 1;
        }

        private static int removeCommonPrimeDivisors(int x, int y)
        {
            while (x != 1)
            {
                var gcd = GetGreatestCommonDivisor(x, y);
                if (gcd == 1)
                    break;

                x /= gcd;
            }

            return x;
        }

        private static int GetGreatestCommonDivisor(int a, int b)
        {
            if (a % b == 0)
                return b;

            return GetGreatestCommonDivisor(b, a % b);
        }
    }
}
