using NUnit.Framework;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution110Tests
    {
        [TestCase("3, 9, 20, null, null, 15, 7", true)]
        [TestCase("1, 2, 2, 3, 3, null, null, 4, 4", false)]
        public void IsBalancedTest(string array, bool expected)
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, Utility.Parse2Array(array), 0);

            Solution110 solution110 = new Solution110();
            bool actual = solution110.IsBalanced(root);

            actual.Should().Be(expected);
        }
    }
}