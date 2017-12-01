using System;

namespace Codility.TimeComplexity
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class FrogJmp
    {
        public static int Solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling((Y - X) / (decimal)D);
        }
    }
}
