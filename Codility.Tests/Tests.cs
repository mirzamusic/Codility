using System.Linq;
using Codility.Arrays;
using Codility.CountingElements;
using Codility.Iterations;
using Codility.Leader;
using Codility.MaximumSliceProblem;
using Codility.PrefixSums;
using Codility.Sorting;
using Codility.StacksAndQueues;
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

        [TestMethod]
        public void TriangleTest()
        {
            Assert.AreEqual(1, Triangle.Solution(new[] { 10, 2, 5, 1, 8, 20 }));
            Assert.AreEqual(0, Triangle.Solution(new[] { 10, 50, 5, 1 }));
        }

        [TestMethod]
        public void DistinctTest()
        {
            Assert.AreEqual(3, Distinct.Solution(new[] { 2, 1, 1, 2, 3, 1 }));
            Assert.AreEqual(0, Distinct.Solution(new int[] { }));
        }

        [TestMethod]
        public void MaxProductOfThreeTest()
        {
            Assert.AreEqual(125, MaxProductOfThree.Solution(new[] { -5, 5, -5, 4 }));
            Assert.AreEqual(60, MaxProductOfThree.Solution(new[] { -3, 1, 2, -2, 5, 6 }));
        }

        [TestMethod]
        public void NumberOfDiscIntersectionsTest()
        {
            Assert.AreEqual(11, NumberOfDiscIntersections.Solution(new[] { 1, 5, 2, 1, 4, 0 }));
        }

        [TestMethod]
        public void BracketsTest()
        {
            Assert.AreEqual(1, Brackets.Solution("{[()()]}"));
            Assert.AreEqual(0, Brackets.Solution("([)()]"));
        }

        [TestMethod]
        public void NestingTest()
        {
            Assert.AreEqual(1, Nesting.Solution("(()(())())"));
            Assert.AreEqual(0, Nesting.Solution("())"));
        }

        [TestMethod]
        public void StoneWallTest()
        {
            Assert.AreEqual(7, StoneWall.Solution(new[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 }));
        }

        [TestMethod]
        public void FishTest()
        {

            var fish = new[] { 0, 5 };
            var directions = new[] { 1, 0 };

            Assert.AreEqual(1, Fish.Solution(fish, directions));

            fish = new[] { 4, 3, 2, 1, 5 };
            directions = new[] { 0, 1, 0, 0, 0 };

            Assert.AreEqual(2, Fish.Solution(fish, directions));
        }

        [TestMethod]
        public void DominatorTest()
        {
            var d1 = Dominator.Solution(new[] { 2, 1, 1, 3, 4 });
            Assert.IsTrue(new[] { -1 }.Contains(d1));

            var d2 = Dominator.Solution(new[] { 3, 4, 3, 2, 3, -1, 3, 3 });
            Assert.IsTrue(new[] { 0, 2, 4, 6, 7 }.Contains(d2));
        }

        [TestMethod]
        public void EquiLeaderTest()
        {
            Assert.AreEqual(2, EquiLeader.Solution(new[] { 4, 3, 4, 4, 4, 2 }));
        }

        [TestMethod]
        public void MaxProfitTest()
        {
            Assert.AreEqual(356, MaxProfit.Solution(new[] { 23171, 21011, 21123, 21366, 21013, 21367 }));
        }

    }
}
