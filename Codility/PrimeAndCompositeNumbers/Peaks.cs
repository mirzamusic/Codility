using System.Collections.Generic;
using System.Linq;

namespace Codility.PrimeAndCompositeNumbers
{
    public class Peaks
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        public static int Solution(int[] A)
        {
            var peaks = new List<int>();
            for (var i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1]) peaks.Add(i);
            }

            for (var size = 1; size <= A.Length; size++)
            {
                if (A.Length % size != 0)
                    continue;

                var find = 0;
                var groups = A.Length / size;
                var ok = true;

                foreach (var peak in peaks)
                {
                    if (peak / size > find)
                    {
                        ok = false;
                        break;
                    }
                    if (peak / size == find)
                        find++;
                }

                if (find != groups)
                    ok = false;

                if (ok)
                    return groups;
            }

            return 0;
        }


        /// <summary>
        /// Correctness:    100%
        /// Performace:     0%
        /// Overall:        54%
        /// </summary>
        public static int Solution1(int[] A)
        {
            if (A.Length < 3)
                return 0;

            var peaks = new List<int>();
            for (var i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                    peaks.Add(i);
            }

            if (peaks.Count <= 1)
                return peaks.Count;

            var totalCount = A.Length;
            var maxSegments = peaks.Count;

            var possibleSegmentsSizes = new List<int>();
            var possibleSegments = maxSegments;
            while (possibleSegments > 1)
            {
                if (totalCount % maxSegments == 0)
                {
                    possibleSegmentsSizes.Add(totalCount / possibleSegments);
                }

                possibleSegments--;
            }

            var fits = true;
            foreach (var size in possibleSegmentsSizes)
            {
                for (var j = 0; j < totalCount; j += size)
                {
                    fits &= peaks.Any(p => p >= j && p < j + size);
                }

                if (fits)
                    return totalCount / size;
            }

            return 1;
        }
    }
}
