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
    public class Solution101Tests
    {
        [Test()]
        public void IsSymmetricTest_ExpectTrue()
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 1, 2, 2, 3, 4, 4, 3 }, 0);

            Solution101 solution101 = new Solution101();
            bool actual = solution101.IsSymmetric(root);

            Assert.AreEqual(true, actual);
        }

        [Test()]
        public void IsSymmetricTest_ExpectFalse()
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 1, 2, 2, null, 3, null, 3 }, 0);

            Solution101 solution101 = new Solution101();
            bool actual = solution101.IsSymmetric(root);

            Assert.AreEqual(false, actual);
        }

        [Test()]
        public void IsSymmetricStackTest_ExpectTrue()
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 1, 2, 2, 3, 4, 4, 3 }, 0);

            Solution101 solution101 = new Solution101();
            bool actual = solution101.IsSymmetric(root);

            Assert.AreEqual(true, actual);
        }

        [Test()]
        public void IsSymmetricStackTest_ExpectFalse()
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 1, 2, 2, null, 3, null, 3 }, 0);

            Solution101 solution101 = new Solution101();
            bool actual = solution101.IsSymmetric(root);

            Assert.AreEqual(false, actual);
        }
    }
}