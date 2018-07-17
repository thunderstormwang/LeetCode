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
            TreeNode root1 = new TreeNode(1);
            TreeNode left1 = new TreeNode(2);
            TreeNode right1 = new TreeNode(3);
            root1.left = left1;
            root1.right = right1;

            TreeNode root2 = new TreeNode(1);
            TreeNode left2 = new TreeNode(2);
            TreeNode right2 = new TreeNode(3);
            root2.left = left2;
            root2.right = right2;

            Solution100 solution100 = new Solution100();
            bool actual = solution100.IsSameTree(root1, root2);

            Assert.AreEqual(true, actual);
        }

        [Test()]
        public void IsSymmetricTest_ExpectedFalse()
        {
            TreeNode root1 = new TreeNode(1);
            TreeNode left1 = new TreeNode(2);
            root1.left = left1;

            TreeNode root2 = new TreeNode(1);
            TreeNode right2 = new TreeNode(3);
            root2.right = right2;

            Solution100 solution100 = new Solution100();
            bool actual = solution100.IsSameTree(root1, root2);

            Assert.AreEqual(false, actual);
        }

        [Test()]
        public void IsSymmetricTest_ExpectedFalse2()
        {
            TreeNode root1 = new TreeNode(1);
            TreeNode left1 = new TreeNode(2);
            TreeNode right1 = new TreeNode(1);
            root1.left = left1;
            root1.right = right1;

            TreeNode root2 = new TreeNode(1);
            TreeNode left2 = new TreeNode(1);
            TreeNode right2 = new TreeNode(2);
            root2.left = left2;
            root2.right = right2;

            Solution100 solution100 = new Solution100();
            bool actual = solution100.IsSameTree(root1, root2);

            Assert.AreEqual(false, actual);
        }
        
        private void BuildTree(int?[] input)
        {
            // 如何從陣列建出 tree??

        }
    }
}