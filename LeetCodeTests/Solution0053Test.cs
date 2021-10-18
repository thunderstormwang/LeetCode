using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0053Test
    {
        [TestCase(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        public void MaxSubArrayTest(int[] array, int expected)
        {
            var solution = new Solution0053();

            var actual = solution.MaxSubArray(array);

            actual.Should().Be(expected);
        }
    }
}