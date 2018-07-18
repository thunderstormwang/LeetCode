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
    public class Solution104Tests
    {
        [Test()]
        public void MaxDepthTest()
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 3, 9, 20, null, null, 15, 7 }, 0);

            Solution104 solution104 = new Solution104();
            int actual = solution104.MaxDepth(root);

            Assert.AreEqual(3, actual);
        }
    }
}