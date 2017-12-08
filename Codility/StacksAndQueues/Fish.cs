using System.Collections.Generic;
using System.Linq;

namespace Codility.StacksAndQueues
{
    public class Fish
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int Solution(int[] A, int[] B)
        {
            if (A.Length == 0)
                return 0;

            var stack = new Stack<int>();

            for (var i = 0; i < A.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(i);
                    continue;
                }

                while (stack.Count > 0 && B[stack.Peek()] == 1 && B[i] == 0 && A[stack.Peek()] < A[i])
                    stack.Pop();

                if (stack.Count == 0 || B[stack.Peek()] != 1 || B[i] != 0)
                    stack.Push(i);
            }

            return stack.Count;
        }

        /// <summary>
        /// Correctness:    50%
        /// Performace:     50%
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int Solution1(int[] A, int[] B)
        {
            if (A.Length == 1)
                return 1;

            var stack = new Stack<FishData>();
            foreach (var fish in A.Select((t, i) => new FishData(i, t, B[i])))
            {
                if (stack.Count == 0)
                {
                    stack.Push(fish);
                    continue;
                }

                var top = stack.Peek();
                if (top.Direction == 1 && fish.Direction == 0)
                {
                    if (top.Size > fish.Size)
                        continue;

                    while (fish.Size > top.Size && top.Direction == 1 && fish.Direction == 0 && stack.Count > 0)
                    {
                        stack.Pop();
                        if (stack.Count > 0)
                            top = stack.Peek();
                    }

                    stack.Push(fish);
                    continue;
                }

                stack.Push(fish);
            }

            return stack.Count;
        }
    }

    public class FishData
    {
        public int Index { get; set; }
        public int Size { get; set; }
        public int Direction { get; set; }

        public FishData(int index, int size, int direction)
        {
            Index = index;
            Size = size;
            Direction = direction;
        }
    }
}
