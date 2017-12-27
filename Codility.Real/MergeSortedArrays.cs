namespace Codility.Real
{
    public class MergeSortedArrays
    {
        public static int[] Solution(int[] a, int[] b)
        {
            var result = new int[a.Length + b.Length];

            var i = 0;
            var iA = 0;
            var iB = 0;
            while (iA < a.Length && iB < b.Length)
            {
                if (a[iA] < b[iB])
                {
                    result[i] = a[iA];
                    iA++;
                    i++;
                    continue;
                }

                if (a[iA] > b[iB])
                {
                    result[i] = b[iB];
                    iB++;
                    i++;
                    continue;
                }

                result[i] = a[iA];
                result[i + 1] = b[iB];
                iA++;
                iB++;
                i += 2;
            }

            if (iA == a.Length && iB == b.Length)
                return result;

            if (iA < a.Length)
            {
                for (var j = iA; j < a.Length; j++)
                {
                    result[i] = a[iA];
                    iA++;
                    i++;
                }
            }

            if (iB < b.Length)
            {
                for (var j = iB; j < b.Length; j++)
                {
                    result[i] = b[iB];
                    iB++;
                    i++;
                }
            }

            return result;
        }
    }
}
