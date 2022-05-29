using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0219Test
    {
        [TestCase(new int[] { 1, 2, 3, 1 }, 3, true)]
        [TestCase(new int[] { 1, 0, 0, 1 }, 1, true)]
        [TestCase(new int[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
        [TestCase(new int[] { 1, 0, 0, 1 }, 0, false)]
        [TestCase(new int[] { 1 }, 2, false)]
        public void ContainsNearbyDuplicateTest(int[] input, int range, bool expected)
        {
            var solution = new Solution0219();
            var actual = solution.ContainsNearbyDuplicate(input, range);

            actual.Should().Be(expected);
        }
    }
}