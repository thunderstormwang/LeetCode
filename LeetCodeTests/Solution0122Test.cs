using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0122Test
    {
        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void MaxProfitTest(int[] array, int expected)
        {
            var solution = new Solution0122();

            var actual = solution.MaxProfit(array);

            actual.Should().Be(expected);
        }
    }
}