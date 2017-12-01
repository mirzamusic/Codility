using System.Linq;
using Codility.Arrays;
using Codility.CountingElements;
using Codility.Iterations;
using Codility.PrefixSums;
using Codility.TimeComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void BinaryGapTest()
        {
            var result = BinnaryGap.Solution(1041);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void OddOccurrencesInArrayTest()
        {
            var result = OddOccurrencesInArray.Solution(new[] { 9, 4, 6, 3, 3, 5, 6, 4, 9 });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CyclicRotationTest()
        {
            Assert.AreEqual("-10005", string.Join("", CyclicRotation.Solution(new[] { 5, -1000 }, 1).Select(i => i.ToString())));
            Assert.AreEqual("97638", string.Join("", CyclicRotation.Solution(new[] { 3, 8, 9, 7, 6 }, 3).Select(i => i.ToString())));
        }

        [TestMethod]
        public void TapeEquilibriumTest()
        {
            Assert.AreEqual(0, TapeEquilibrium.Solution(new[] { 1, 1 }));
            Assert.AreEqual(1, TapeEquilibrium.Solution(new[] { 3, 1, 2, 4, 3 }));
        }

        [TestMethod]
        public void PermMissingElemTest()
        {
            Assert.AreEqual(3, PermMissingElem.Solution(new[] { 1, 2, 4 }));
        }

        [TestMethod]
        public void FrogJmpTest()
        {
            Assert.AreEqual(3, FrogJmp.Solution(10, 85, 30));
        }

        [TestMethod]
        public void PermCheckTest()
        {
            Assert.AreEqual(1, PermCheck.Solution(new[] { 1, 2, 3 }));
            Assert.AreEqual(0, PermCheck.Solution(new[] { 1, 2, 3, 7 }));
        }

        [TestMethod]
        public void FrogRiverOneTest()
        {
            Assert.AreEqual(-1, FrogRiverOne.Solution(2, new[] { 1, 1, 1, 1 }));
            Assert.AreEqual(4, FrogRiverOne.Solution(3, new[] { 1, 3, 1, 3, 2, 1, 3 }));
            Assert.AreEqual(-1, FrogRiverOne.Solution(2, new[] { 2, 2, 2, 2, 2 }));
            Assert.AreEqual(-1, FrogRiverOne.Solution(5, new[] { 1 }));
            Assert.AreEqual(6, FrogRiverOne.Solution(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 }));
        }

        [TestMethod]
        public void MissingIntegerTest()
        {
            Assert.AreEqual(4, MissingInteger.Solution(new[] { 1, 2, 3 }));
            Assert.AreEqual(1, MissingInteger.Solution(new[] { 2, 2, 3 }));
        }

        [TestMethod]
        public void MaxCountersTest()
        {
            Assert.AreEqual("1", string.Join("", MaxCounters.Solution(1, new[] { 1 }).Select(t => t.ToString())));
            Assert.AreEqual("32242", string.Join("", MaxCounters.Solution(5, new[] { 3, 4, 4, 6, 1, 4, 4 }).Select(t => t.ToString())));
        }

        [TestMethod]
        public void CountDivTest()
        {
            Assert.AreEqual(3, CountDiv.Solution(6, 11, 2));
            Assert.AreEqual(0, CountDiv.Solution(1, 1, 11));
        }

        [TestMethod]
        public void PassingCarsTest()
        {
            Assert.AreEqual(5, PassingCars.Solution(new[] { 0, 1, 0, 1, 1 }));
        }

        [TestMethod]
        public void MinAvgTwoSliceTest()
        {
            Assert.AreEqual(2, MinAvgTwoSlice.Solution(new[] { -3, -5, -8, -4, -10 }, 5));
            Assert.AreEqual(1, MinAvgTwoSlice.Solution(new[] { 4, 2, 2, 5, 1, 5, 8 }, 7));
        }

        [TestMethod]
        public void GenomicRangeQueryTest()
        {
            var p = new[] { 0, 0, 1 };
            var q = new[] { 0, 1, 1 };
            Assert.AreEqual("112", string.Join("", GenomicRangeQuery.Solution("AC", p, q).Select(t => t.ToString())));

            p = new[] { 0 };
            q = new[] { 0 };
            Assert.AreEqual("1", string.Join("", GenomicRangeQuery.Solution("A", p, q).Select(t => t.ToString())));

            p = new[] { 2, 5, 0 };
            q = new[] { 4, 5, 6 };
            Assert.AreEqual("241", string.Join("", GenomicRangeQuery.Solution("CAGCCTA", p, q).Select(t => t.ToString())));
        }


    }
}
