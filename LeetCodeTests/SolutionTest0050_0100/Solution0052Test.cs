using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0050_0100
{
    [TestFixture]
    public class Solution0052Test
    {
        [TestCase(1,
            1)]
        [TestCase(2,
            0)]
        [TestCase(3,
            0)]
        [TestCase(4,
            2)]
        public void TotalNQueens(int n, int expected)
        {
            var solution = new Solution0052();
            var actual = solution.TotalNQueens(n);

            actual.Should().Be(expected);
        }
    }
}