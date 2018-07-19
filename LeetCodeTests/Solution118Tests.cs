using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution118Tests
    {
        [Test()]
        public void GenerateTest()
        {
            Solution118 solution118 = new Solution118();
            IList<IList<int>> actual = solution118.Generate(5);

            Assert.AreEqual(new int[] { 1 }, actual[0]);
            Assert.AreEqual(new int[] { 1, 1 }, actual[1]);
            Assert.AreEqual(new int[] { 1, 2, 1 }, actual[2]);
            Assert.AreEqual(new int[] { 1, 3, 3, 1 }, actual[3]);
            Assert.AreEqual(new int[] { 1, 4, 6, 4, 1 }, actual[4]);
        }
    }
}