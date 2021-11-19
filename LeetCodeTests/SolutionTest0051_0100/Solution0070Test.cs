using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100
{
    [TestFixture]
    public class Solution0070Test
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(5, 8)]
        public void ClimbStairsTest(int n, int expected)
        {
            var solution = new Solution0070();

            var actual = solution.ClimbStairs(n);

            actual.Should().Be(expected);
        }
    }
}