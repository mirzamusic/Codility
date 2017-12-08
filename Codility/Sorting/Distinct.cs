using System.Linq;

namespace Codility.Sorting
{
    public class Distinct
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        public static int Solution(int[] A)
        {
            return A.Distinct().Count();
        }
    }
}
