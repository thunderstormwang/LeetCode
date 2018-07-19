using NUnit.Framework;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution108Tests
    {
        [Test()]
        public void SortedArrayToBSTTest()
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 3, 9, 20, null, null, 15, 7 }, 0);

            Solution107 solution107 = new Solution107();
            IList<IList<int>> actual = solution107.LevelOrderBottom(root);

            Assert.AreEqual(new int[] { 15, 7 }, actual[0]);
            Assert.AreEqual(new int[] { 9, 20 }, actual[1]);
            Assert.AreEqual(new int[] { 3 }, actual[2]);
        }
    }
}