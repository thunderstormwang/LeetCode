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
    public class Solution100Tests
    {
        [Test()]
        public void IsSymmetricTest_ExpectedTrue()
        {
            TreeNode root = new TreeNode(1);
            TreeNode left = new TreeNode(2);
            TreeNode right = new TreeNode(3);

            int?[] AA = new int?[] { };

            Assert.Fail();
        }

        [Test()]
        public void IsSymmetricTest_ExpectedFalse()
        {
            Assert.Fail();
        }

        private void BuildTree(int?[] input)
        {
            // 如何從陣列建出 tree??

        }
    }
}