using System.Collections.Generic;
using System.Linq;

namespace Codility.StacksAndQueues
{
    /// <summary>
    /// Correctness:    100%
    /// Performace:     100%
    /// </summary>
    public class Brackets
    {
        public static int Solution(string S)
        {
            if (string.IsNullOrWhiteSpace(S))
                return 1;

            var map = new Dictionary<string, string> { { "{", "}" }, { "[", "]" }, { "(", ")" } };

            var stack = new Stack<string>();
            foreach (var bracket in S.ToCharArray().Select(a => a.ToString()))
            {
                if (stack.Count == 0)
                {
                    if (")]}".Contains(bracket))
                        return 0;

                    stack.Push(bracket);
                    continue;
                }

                var top = stack.Peek();
                if (map[top] == bracket)
                    stack.Pop();
                else
                {
                    if (")]}".Contains(bracket))
                        return 0;

                    stack.Push(bracket);
                }
            }

            return stack.Count > 0 ? 0 : 1;
        }
    }
}
