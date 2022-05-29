using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0137Test
    {
        [TestCase(new int[] { 2, 2, 3, 2 }, 3)]
        [TestCase(new int[] { 0, 1, 0, 1, 0, 1, 99 }, 99)]
        [TestCase(new int[] { 2, 2, 2147483647, 2 }, 2147483647)]
        [TestCase(new int[] { 2, 2, -2147483648, 2 }, -2147483648)]
        public void SingleNumberTest(int[] input, int expected)
        {
            var solution = new Solution0137();
            var actual = solution.SingleNumber(input);

            actual.Should().Be(expected);
        }
    }
}