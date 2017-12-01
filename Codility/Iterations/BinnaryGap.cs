using System;
using System.Linq;

namespace Codility.Iterations
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     not assessed 
    /// </summary>
    public class BinnaryGap
    {
        public static int Solution(int n)
        {
            if (n == 0)
                return 0;

            var binary = Convert.ToString(n, 2).TrimEnd('0');
            var segments = binary.Split('1');

            if (!segments.Any() || segments.All(string.IsNullOrWhiteSpace))
                return 0;

            return segments.Where(segment => !string.IsNullOrWhiteSpace(segment)).Max(segment => segment.Length);
        }
    }
}
