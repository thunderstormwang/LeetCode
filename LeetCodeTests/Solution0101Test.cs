using NUnit.Framework;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0101Test
    {
        [TestCase("1, 2, 2, 3, 4, 4, 3", true)]
        [TestCase("1, 2, 2, null, 3, null, 3", false)]
        public void IsSymmetricTest(string array, bool expected)
        {
            var root = new TreeNode(0);
            root = Utility.BuildTree(root, Utility.Parse2Array(array), 0);

            var solution = new Solution0101();
            var actual = solution.IsSymmetric(root);

            actual.Should().Be(expected);
        }
    }
}