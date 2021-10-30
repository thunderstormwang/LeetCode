using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0045Test
    {
        [TestCase(new int[] { 2, 3, 1, 1, 4 },
            2)]
        [TestCase(new int[] { 2, 3, 1, 0, 4 },
            2)]
        [TestCase(new int[] { 2, 1},
            1)]
        public void JumpTest(int[] nums,
            int expected)
        {
            var solution = new Solution0045();

            var actual = solution.Jump(nums);

            actual.Should().Be(expected);
        }
    }
}