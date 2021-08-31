using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution016Test
    {
        [TestCase(new int[] { -1, 2, 1, -4 },
            1,
            2)]
        [TestCase(new int[] { 0, 0, 0 },
            1,
            0)]
        [TestCase(new int[] { 0, 2, 1, -3 },
            1,
            0)]
        public void ThreeSumClosestTest(int[] input,
            int target,
            int expected)
        {
            var solution016 = new Solution016();

            var actual = solution016.ThreeSumClosest(input,
                target);

            actual.Should().Be(expected);
        }
    }
}