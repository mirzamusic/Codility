namespace Codility.Real
{
    public class SplitTheArray
    {
        public static int Solution(int[] A, int N)
        {
            var sums = new int[A.Length];
            sums[0] = A[0] == N ? 1 : 0;

            for (var i = 1; i < A.Length; i++)
            {
                sums[i] = A[i] == N ? sums[i - 1] + 1 : sums[i - 1];
            }

            for (var i = 0; i < A.Length; i++)
            {
                var left = i + 1;
                var right = A.Length - left;

                if (sums[i] == right - (sums[A.Length - 1] - sums[i]))
                    return i + 1;
            }

            return 0;
        }
    }
}
