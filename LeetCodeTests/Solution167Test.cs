using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution167Test
    {
        [TestCase(new int[] { 2, 7, 11, 15 },
            9,
            new int[] { 1, 2 })]
        [TestCase(new int[] { 2, 3, 4 },
            6,
            new int[] { 1, 3 })]
        [TestCase(new int[] { -1, 0 },
            -1,
            new int[] { 1, 2 })]
        public void TwoSumTest(int[] number,
            int target,
            int[] expected)
        {
            var solution167 = new Solution167();
            var actual = solution167.TwoSum(number, target);

            actual.Should().Equal(expected);
        }
    }
}