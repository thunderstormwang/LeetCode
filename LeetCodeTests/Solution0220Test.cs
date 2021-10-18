using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0220Test
    {
        [TestCase(new int[] { 1, 2, 3, 1 },
            3,
            0,
            true)]
        [TestCase(new int[] { 1, 0, 1, 1 },
            1,
            2,
            true)]
        [TestCase(new int[] { 1, 5, 9, 1, 5, 9 },
            2,
            3,
            false)]
        [TestCase(new int[] { 1, 5, 9, 1, 5, 9 },
            2,
            4,
            true)]
        [TestCase(new int[] { 1 },
            2,
            3,
            false)]
        [TestCase(new int[] { 1 },
            2,
            3,
            false)]
        [TestCase(new int[] { 1, 2 },
            0,
            1,
            false)]
        [TestCase(new int[] { -2147483648, 2147483647 },
            1,
            2147483647,
            false)]
        public void ContainsNearbyAlmostDuplicateTest(int[] input,
            int range,
            int diff,
            bool expected)
        {
            var solution = new Solution0220();
            var actual = solution.ContainsNearbyAlmostDuplicate(input,
                range,
                diff);

            actual.Should().Be(expected);
        }
    }
}