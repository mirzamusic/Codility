using System.Collections.Generic;

namespace Codility.StacksAndQueues
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class Nesting
    {
        public static int Solution(string S)
        {
            if (string.IsNullOrWhiteSpace(S))
                return 1;

            var stack = new Stack<char>();
            foreach (var bracket in S)
            {
                if (stack.Count == 0)
                {
                    if (bracket == ')')
                        return 0;

                    stack.Push(bracket);
                    continue;
                }

                var top = stack.Peek();
                if (top == '(' && bracket == ')')
                    stack.Pop();
                else
                {
                    stack.Push(bracket);
                }
            }

            return stack.Count > 0 ? 0 : 1;
        }
    }
}
