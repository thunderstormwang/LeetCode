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
    public class Solution101Tests
    {
        [TestCase("1, 2, 2, 3, 4, 4, 3", true)]
        [TestCase("1, 2, 2, null, 3, null, 3", false)]
        public void IsSymmetricTest(string array, bool expected)
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, Utility.Parse2Array(array), 0);

            Solution101 solution101 = new Solution101();
            bool actual = solution101.IsSymmetric(root);

            actual.Should().Be(expected);
        }
    }
}