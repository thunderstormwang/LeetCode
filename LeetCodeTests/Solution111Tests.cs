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
    public class Solution111Tests
    {
        [Test()]
        public void MinDepthTest()
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 3, 9, 20, null, null, 15, 7 }, 0);

            Solution111 solution111 = new Solution111();
            int actual = solution111.MinDepth(root);

            Assert.AreEqual(2, actual);
        }
    }
}