using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0029Test
    {
        [TestCase(10, 3, 3)]
        [TestCase(10, -3, -3)]
        [TestCase(-10, 3, -3)]
        [TestCase(-10, -3, 3)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(1, -1, -1)]
        [TestCase(-1, 1, -1)]
        [TestCase(-1, -1, 1)]
        [TestCase(2147483647, 1, 2147483647)]
        [TestCase(2147483647, -1, -2147483647)]
        [TestCase(-2147483648, 1, 2147483647)]
        [TestCase(-2147483648, -1, -2147483648)]
        public void DivideTest(int dividend, int divisor, int expected)
        {
            var solution = new Solution0029();
            var actual = solution.Divide(dividend, divisor);

            actual.Should().Be(expected);
        }
    }
}