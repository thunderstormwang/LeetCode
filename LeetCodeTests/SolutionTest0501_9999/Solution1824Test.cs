using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999
{
    [TestFixture]
    [Category("SolutionTest0501_9999")]
    public class Solution1824Test
    {
        [TestCase(new int[] { 0, 1, 2, 3, 0 }, 2)]
        [TestCase(new int[] { 0, 1, 1, 3, 3, 0 }, 0)]
        [TestCase(new int[] { 0, 2, 1, 0, 3, 0 }, 2)]
        public void MinSideJumps(int[] obstacles, int expected)
        {
            var solution = new Solution1824();
            var actual = solution.MinSideJumps(obstacles);

            actual.Should().Be(expected);
        }
    }
}