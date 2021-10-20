using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0268Test
    {
        [TestCase(new int[] { 0 },
            1)]
        [TestCase(new int[] { 0, 1 },
            2)]
        [TestCase(new int[] { 1, 2 },
            0)]
        [TestCase(new int[] { 0, 2 },
            1)]
        [TestCase(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 },
            8)]
        public void MissingNumber(int[] input,
            int expected)
        {
            var solution = new Solution0268();
            var actual = solution.MissingNumber(input);

            actual.Should().Be(expected);
        }
    }
}