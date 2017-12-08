using System.Collections.Generic;
using System.Linq;

namespace Codility.Leader
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class Dominator
    {
        public static int Solution(int[] A)
        {
            var stack = new Stack<int>();

            for (var i = 0; i < A.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(i);
                    continue;
                }

                if (A[stack.Peek()] != A[i])
                {
                    stack.Pop();
                    continue;
                }

                stack.Push(i);
            }

            return stack.Count > 0 && A.Count(a => a == A[stack.Peek()]) > A.Length / 2 ? stack.Peek() : -1;
        }
    }
}
