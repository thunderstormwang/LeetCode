using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture()]
    public class Solution136Tests
    {
        [TestCase(new int[] { 2, 2, 1 }, 1)]
        [TestCase(new int[] { 4, 1, 2, 1, 2 }, 4)]
        public void SingleNumberTest(int[] input, int expected)
        {
            Solution136 solution136 = new Solution136();
            int actual = solution136.SingleNumber(input);

            actual.Should().Be(expected);
        }
    }
}