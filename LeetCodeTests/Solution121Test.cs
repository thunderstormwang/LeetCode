using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution121Test
    {
        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void MaxProfitTest(int[] array, int expected)
        {
            Solution121 solution121 = new Solution121();

            int actual = solution121.MaxProfit(array);

            actual.Should().Be(expected);
        }
    }
}