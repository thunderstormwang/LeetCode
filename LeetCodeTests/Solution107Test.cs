using NUnit.Framework;
using System.Collections.Generic;
using LeetCode;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution107Test
    {
        [Test()]
        public void LevelOrderBottomTest()
        {
            var root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 3, 9, 20, null, null, 15, 7 }, 0);

            var solution107 = new Solution107();
            var actual = solution107.LevelOrderBottom(root);

            Assert.AreEqual(new int[] { 15, 7 }, actual[0]);
            Assert.AreEqual(new int[] { 9, 20 }, actual[1]);
            Assert.AreEqual(new int[] { 3 }, actual[2]);
        }
    }
}