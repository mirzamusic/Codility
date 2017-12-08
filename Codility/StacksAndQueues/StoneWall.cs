using System.Collections.Generic;

namespace Codility.StacksAndQueues
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class StoneWall
    {
        public static int Solution(int[] H)
        {
            var count = 0;
            var stack = new Stack<int>();
            var height = 0;

            foreach (var size in H)
            {
                if (height == size)
                    continue;

                if (height < size)
                {
                    stack.Push(size - height);
                    height += size - height;
                    count++;
                    continue;
                }

                while (height > size)
                {
                    var removed = stack.Pop();
                    height -= removed;
                }

                if (height == size)
                    continue;

                if (height < size)
                {
                    stack.Push(size - height);
                    height += size - height;
                    count++;
                }
            }

            return count;
        }
    }
}
