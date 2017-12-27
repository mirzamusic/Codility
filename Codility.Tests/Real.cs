using Codility.Real;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Tests
{
    [TestClass]
    public class Real
    {
        [TestMethod]
        public void NegBaseTest()
        {
            Assert.AreEqual("1101", string.Join("", NegBase.Solution(-9)));
            Assert.AreEqual("10011", string.Join("", NegBase.Solution(9)));
        }

        [TestMethod]
        public void SplitTheArrayTest()
        {
            Assert.AreEqual(4, SplitTheArray.Solution(new[] { 5, 5, 2, 3, 5, 1, 6 }, 5));
        }

        [TestMethod]
        public void KnightOnInfiniteChesboardTest()
        {
            Assert.AreEqual(3, KnightOnInfiniteChesboard.Solution(4, 5));
        }


        [TestMethod]
        public void MergeSortedArraysTest()
        {
            Assert.AreEqual("0,1", string.Join(",", MergeSortedArrays.Solution(new[] { 1 }, new[] { 0 })));
            Assert.AreEqual("1", string.Join(",", MergeSortedArrays.Solution(new[] { 1 }, new int[0])));
            Assert.AreEqual("", string.Join(",", MergeSortedArrays.Solution(new int[0], new int[0])));
            Assert.AreEqual("1,2,2,3,4,5", string.Join(",", MergeSortedArrays.Solution(new[] { 1, 2, 3 }, new[] { 2, 4, 5 })));
        }
    }
}
