using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0069Test
    {
        [TestCase(4, 2)]
        [TestCase(8, 2)]
        public void MySqrtTest(int x, int expected)
        {
            var solution = new Solution0069();

            var actual = solution.MySqrt(x);

            actual.Should().Be(expected);
        }
    }
}