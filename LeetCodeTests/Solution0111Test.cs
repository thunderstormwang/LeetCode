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
    public class Solution0111Test
    {
        [TestCase("3, 9, 20, null, null, 15, 7", 2)]
        public void MinDepthTest(string array, int expected)
        {
            var root = new TreeNode(0);
            root = Utility.BuildTree(root, Utility.Parse2Array(array), 0);

            var solution = new Solution0111();
            var actual = solution.MinDepth(root);

            actual.Should().Be(expected);
        }
    }
}