using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0121Test
    {
        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void MaxProfitTest(int[] array, int expected)
        {
            var solution = new Solution0121();

            var actual = solution.MaxProfit(array);

            actual.Should().Be(expected);
        }
    }
}