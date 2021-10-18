using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0189Test
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 },
            3,
            new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 },
            10,
            new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 },
            14,
            new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 },
            3,
            new int[] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 },
            9,
            new int[] { 4, 5, 6, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 },
            4,
            new int[] { 3, 4, 5, 6, 1, 2 })]
        public void RotateTest(int[] nums,
            int k,
            int[] expected)
        {
            var solution = new Solution0189();
            solution.Rotate(nums,
                k);

            nums.Should().Equal(expected);
        }
    }
}