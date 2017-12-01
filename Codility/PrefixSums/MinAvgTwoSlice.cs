namespace Codility.PrefixSums
{
    public class MinAvgTwoSlice
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        public static int Solution(int[] A, int N)
        {
            var index = 0;
            var value = decimal.MaxValue;

            for (var i = 0; i < A.Length - 1; i++)
            {

                if ((A[i] + A[i + 1]) / (decimal)2 < value)
                {
                    value = (A[i] + A[i + 1]) / (decimal)2;
                    index = i;
                }

                if (i < A.Length - 2 && (A[i] + A[i + 1] + A[i + 2]) / (decimal)3 < value)
                {
                    value = (A[i] + A[i + 1] + A[i + 2]) / (decimal)3;
                    index = i;
                }
            }

            return index;
        }
    }
}
