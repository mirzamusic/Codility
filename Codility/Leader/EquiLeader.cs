using System.Collections.Generic;
using System.Linq;

namespace Codility.Leader
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class EquiLeader
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

            var leaderCount = stack.Count > 0 ? A.Count(a => A[stack.Peek()] == a) : 0;
            var leader = leaderCount > 0 ? A[stack.Peek()] : -1;
            var equiCount = 0;
            var soFarLeader = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] == leader)
                    soFarLeader++;

                var left = soFarLeader > i - soFarLeader + 1;
                var right = leaderCount - soFarLeader > A.Length - (i + 1) - (leaderCount - soFarLeader);

                if (left && right)
                    equiCount++;
            }

            return equiCount;
        }
    }
}
