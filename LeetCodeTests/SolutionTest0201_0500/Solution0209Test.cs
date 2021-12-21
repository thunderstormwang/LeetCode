using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500
{
    [TestFixture]
    public class Solution0209Test
    {
        [TestCase(7,
            new int[] { 2, 3, 1, 2, 4, 3 },
            2)]
        [TestCase(4,
            new int[] { 1, 4, 4 },
            1)]
        [TestCase(11,
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            0)]
        [TestCase(11,
            new int[] { 1, 2, 3, 4, 5 },
            3)]
        public void MinSubArrayLen_Brutal(int target,
            int[] nums,
            int expected)
        {
            var solution = new Solution0209();
            var actual = solution.MinSubArrayLen_Brutal(target,
                nums);

            actual.Should().Be(expected);
        }
        
        [TestCase(7,
            new int[] { 2, 3, 1, 2, 4, 3 },
            2)]
        [TestCase(4,
            new int[] { 1, 4, 4 },
            1)]
        [TestCase(11,
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            0)]
        [TestCase(11,
            new int[] { 1, 2, 3, 4, 5 },
            3)]
        public void MinSubArrayLen_TwoPointer_Version1(int target,
            int[] nums,
            int expected)
        {
            var solution = new Solution0209();
            var actual = solution.MinSubArrayLen_TwoPointer_Version1(target,
                nums);

            actual.Should().Be(expected);
        }
        
        [TestCase(7,
            new int[] { 2, 3, 1, 2, 4, 3 },
            2)]
        [TestCase(4,
            new int[] { 1, 4, 4 },
            1)]
        [TestCase(11,
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            0)]
        [TestCase(11,
            new int[] { 1, 2, 3, 4, 5 },
            3)]
        public void MinSubArrayLen_TwoPointer_Version2(int target,
            int[] nums,
            int expected)
        {
            var solution = new Solution0209();
            var actual = solution.MinSubArrayLen_TwoPointer_Version2(target,
                nums);

            actual.Should().Be(expected);
        }
    }
}