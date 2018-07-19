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
    public class Solution110Tests
    {
        [Test()]
        public void IsBalancedTest_ExpectTrue()
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 3, 9, 20, null, null, 15, 7 }, 0);

            Solution110 solution110 = new Solution110();
            bool actual = solution110.IsBalanced(root);

            Assert.AreEqual(true, actual);
        }

        [Test()]
        public void IsBalancedTest_ExpectFalse()
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 1, 2, 2, 3, 3, null, null, 4, 4 }, 0);

            Solution110 solution110 = new Solution110();
            bool actual = solution110.IsBalanced(root);

            Assert.AreEqual(false, actual);
        }

    }
}