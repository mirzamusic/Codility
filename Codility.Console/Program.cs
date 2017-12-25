using System.Linq;

namespace Codility.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new[] { 1, 3, 6, 4, 1, 2 };
            var sorted = a.Where(i => i > 0).Distinct().OrderBy(i => i).ToArray();

            for (var i = 0; i < sorted.Length - 1; i++)
            {
                if (sorted[i] + 1 == sorted[i + 1])
                    continue;

                System.Console.WriteLine(sorted[i] + 1);
                break;
            }
        }
    }
}
