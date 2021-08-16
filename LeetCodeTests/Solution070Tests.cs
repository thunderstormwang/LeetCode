using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture()]
    public class Solution070Tests
    {
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void ClimbStairsTest(int x, int expected)
        {
            Solution70 solution70 = new Solution70();

            int actual = solution70.ClimbStairs(x);

            actual.Should().Be(expected);
        }
    }
}