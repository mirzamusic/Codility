using System.Linq;

namespace Codility.CountingElements
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            var steps = Enumerable.Repeat(-1, X + 1).ToArray();
            steps[0] = 0;
            for (var i = 0; i < A.Length; i++)
            {
                steps[A[i]] = steps[A[i]] == -1 ? i : steps[A[i]];
            }

            if (steps.Take(X + 1).Contains(-1))
                return -1;

            return steps.Max();
        }
    }
}
