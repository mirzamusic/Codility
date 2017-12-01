namespace Codility.TimeComplexity
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            if (A.Length == 0)
                return 1;

            var sums = new int[A.Length];
            var sumsShouldBe = new int[A.Length + 1];
            for (var i = 0; i < A.Length; i++)
            {
                sums[i] = i == 0 ? A[i] : A[i] + sums[i - 1];
                sumsShouldBe[i] = i == 0 ? sumsShouldBe[i] + 1 : i + 1 + sumsShouldBe[i - 1];
                if (i == A.Length - 1)
                {
                    sumsShouldBe[i + 1] = i + 2 + sumsShouldBe[i];
                }
            }

            return sumsShouldBe[sumsShouldBe.Length - 1] - sums[sums.Length - 1];
        }
    }
}
