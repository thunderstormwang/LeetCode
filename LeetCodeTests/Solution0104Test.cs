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
    public class Solution0104Test
    {
        [TestCase("3, 9, 20, null, null, 15, 7", 3)]
        public void MaxDepthTest(string array, int expected)
        {
            var root = new TreeNode(0);
            root = Utility.BuildTree(root, Utility.Parse2Array(array), 0);

            var solution = new Solution0104();
            var actual = solution.MaxDepth(root);

            actual.Should().Be(expected);
        }
    }
}