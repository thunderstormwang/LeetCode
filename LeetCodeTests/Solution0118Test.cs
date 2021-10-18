using NUnit.Framework;
using System.Collections.Generic;
using LeetCode;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0118Test
    {
        [Test()]
        public void GenerateTest()
        {
            var solution = new Solution0118();
            var actual = solution.Generate(5);

            Assert.AreEqual(new int[] { 1 }, actual[0]);
            Assert.AreEqual(new int[] { 1, 1 }, actual[1]);
            Assert.AreEqual(new int[] { 1, 2, 1 }, actual[2]);
            Assert.AreEqual(new int[] { 1, 3, 3, 1 }, actual[3]);
            Assert.AreEqual(new int[] { 1, 4, 6, 4, 1 }, actual[4]);
        }
    }
}