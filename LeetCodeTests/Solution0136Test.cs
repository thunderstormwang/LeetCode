using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0136Tests
    {
        [TestCase(new int[] { 2, 2, 1 }, 1)]
        [TestCase(new int[] { 4, 1, 2, 1, 2 }, 4)]
        public void SingleNumberTest(int[] input, int expected)
        {
            var solution = new Solution0136();
            var actual = solution.SingleNumber(input);

            actual.Should().Be(expected);
        }
    }
}