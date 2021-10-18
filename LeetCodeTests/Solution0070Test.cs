using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0070Test
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        public void ClimbStairsTest(int x, int expected)
        {
            var solution = new Solution0070();

            var actual = solution.ClimbStairs(x);

            actual.Should().Be(expected);
        }
    }
}