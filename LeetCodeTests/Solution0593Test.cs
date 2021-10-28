using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0593Test
    {
        [TestCase(new int[] { 0, 0 },
            new int[] { 1, 1 },
            new int[] { 1, 0 },
            new int[] { 0, 1 },
            true)]
        [TestCase(new int[] { 0, 0 },
            new int[] { 1, 1 },
            new int[] { 1, 0 },
            new int[] { 0, 12 },
            false)]
        [TestCase(new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 },
            true)]
        [TestCase(new int[] { 0, 0 },
            new int[] { 5, 0 },
            new int[] { 5, 4 },
            new int[] { 0, 4 },
            false)]
        public void ValidSquareTest(int[] p1,
            int[] p2,
            int[] p3,
            int[] p4,
            bool expected)
        {
            var solution = new Solution0593();
            var actual = solution.ValidSquare(p1,
                p2,
                p3,
                p4);

            actual.Should().Be(expected);
        }
    }
}