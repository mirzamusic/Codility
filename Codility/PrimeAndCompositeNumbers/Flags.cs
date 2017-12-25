using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.PrimeAndCompositeNumbers
{
    public class Flags
    {
        /// <summary>
        /// Correctness:    100%
        /// Performace:     100%
        /// </summary>
        public static int Solution(int[] A)
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

            var maxFlags = peaks.Count;
            var minFlags = 1;
            var result = 0;
            while (maxFlags >= minFlags)
            {
                var flags = (minFlags + maxFlags) / 2;
                if (CheckFlags(flags, peaks))
                {
                    result = flags;
                    minFlags = flags + 1;
                    continue;
                }

                maxFlags = flags - 1;
            }

            return result;
        }

        private static bool CheckFlags(int flagsCount, List<int> flags)
        {
            var i = 1;
            var lastFlag = flags[0];
            var actualFlags = flagsCount - 1;
            while (actualFlags > 0 && i < flags.Count)
            {
                if (flags[i] - lastFlag >= flagsCount)
                {
                    actualFlags--;
                    lastFlag = flags[i];
                }

                i++;
            }

            return actualFlags == 0;
        }


        /// <summary>
        /// 33% :/
        /// </summary>
        public static int Solution1(int[] A)
        {
            var peaks = new List<int>();

            for (var i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                    peaks.Add(i);
            }

            if (peaks.Count <= 1)
                return peaks.Count;

            var diffs = new int[peaks.Count - 1];
            for (var i = 1; i < peaks.Count; i++)
            {
                diffs[i - 1] = Math.Abs(peaks[i] - peaks[i - 1]);
            }

            if (diffs.Length == 1)
                return (peaks.Count / diffs[0]) + 1;

            var min = diffs.Min();
            var max = diffs.Max();

            var result = Enumerable.Range(min, max - min).FirstOrDefault(i => i <= peaks.Count / i);
            return result + 1;
        }
    }
}
