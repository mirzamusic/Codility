namespace Codility.Arrays
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     not assessed 
    /// </summary>
    public class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            if (A.Length == 0 || K == 0)
                return A;

            var realMoves = K % A.Length;
            if (realMoves == 0)
                return A;

            var rest = 0;
            var array = new int[A.Length];
            for (var i = 0; i < A.Length; i++)
            {
                var newIndex = realMoves + i;
                if (newIndex < A.Length)
                {
                    array[newIndex] = A[i];
                }
                else
                {
                    array[rest] = A[i];
                    rest++;
                }
            }

            return array;
        }
    }
}
