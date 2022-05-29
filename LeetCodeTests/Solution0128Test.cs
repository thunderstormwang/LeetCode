using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0128Test
    {
        [TestCase(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
        [TestCase(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
        [TestCase(new int[] { 0, 3, 2, 1, 4, 4, 6, 1, 1, 2, 3 }, 5)]
        [TestCase(new int[] { 0, 3, 6, 3 }, 1)]
        public void LongestConsecutiveTest(int[] input, int expected)
        {
            var solution = new Solution0128();
            var actual = solution.LongestConsecutive(input);

            actual.Should().Be(expected);
        }
    }
}