using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0042Test
    {
        [TestCase(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
        [TestCase(new int[] { 4, 2, 0, 3, 2, 5 }, 9)]
        [TestCase(new int[] { 7, 0, 9 }, 7)]
        [TestCase(new int[] { 5, 4, 3 }, 0)]
        [TestCase(new int[] { 3, 4, 5 }, 0)]
        public void TrapTest(int[] inputArray, int expected)
        {
            var solution = new Solution0042();

            var actual = solution.Trap(inputArray);

            actual.Should().Be(expected);
        }
    }
}