using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution053Tests
    {
        [TestCase(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        public void MaxSubArrayTest(int[] array, int expected)
        {
            Solution53 solution53 = new Solution53();

            int actual = solution53.MaxSubArray(array);

            actual.Should().Be(expected);
        }
    }
}