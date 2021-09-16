using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution112Test
    {
        [TestCase("5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1", 22, true)]
        public void HasPathSumTest(string array, int pathSum, bool expected)
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, Utility.Parse2Array(array), 0);

            Solution112 solution112 = new Solution112();
            bool actual = solution112.HasPathSum(root, pathSum);

            actual.Should().Be(expected);
        }
    }
}