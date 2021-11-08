using FluentAssertions;
using LeetCode.Solution0000_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0000_0050
{
    [TestFixture]
    public class Solution0031Test
    {
        [TestCase(new int[] { 1, 2, 3 },
            new int[] { 1, 3, 2 })]
        [TestCase(new int[] { 1, 3, 2 },
            new int[] { 2, 1, 3 })]
        [TestCase(new int[] { 2, 1, 3 },
            new int[] { 2, 3, 1 })]
        [TestCase(new int[] { 2, 3, 1 },
            new int[] { 3, 1, 2 })]
        [TestCase(new int[] { 3, 1, 2 },
            new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 3, 2, 1 },
            new int[] { 1, 2, 3 })]
        public void NextPermutationTest(int[] nums,
            int[] expected)
        {
            var solution = new Solution0031();
            solution.NextPermutation(nums);

            nums.Should().Equal(expected);
        }
    }
}