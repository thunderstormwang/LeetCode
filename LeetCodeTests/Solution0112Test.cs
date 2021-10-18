using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0112Test
    {
        [TestCase("5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1", 22, true)]
        public void HasPathSumTest(string array, int pathSum, bool expected)
        {
            var root = new TreeNode(0);
            root = Utility.BuildTree(root, Utility.Parse2Array(array), 0);

            var solution = new Solution0112();
            var actual = solution.HasPathSum(root, pathSum);

            actual.Should().Be(expected);
        }
    }
}