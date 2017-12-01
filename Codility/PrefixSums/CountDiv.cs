namespace Codility.PrefixSums
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class CountDiv
    {
        public static int Solution(int A, int B, int K)
        {
            return B / K - A / K + (A % K == 0 ? 1 : 0);
        }
    }
}
