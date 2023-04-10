using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300
{
    [TestFixture]
    public class Solution0239Test
    {
        [TestCase(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3, new int[] { 3, 3, 5, 5, 6, 7 })]
        [TestCase(new int[] { 1 }, 1, new int[] { 1 })]
        [TestCase(new int[] { 1, -1 }, 1, new int[] { 1, -1 })]
        [TestCase(new int[] { 9, 11 }, 2, new int[] { 11 })]
        [TestCase(new int[] { 4, -2 }, 2, new int[] { 4 })]
        [TestCase(new int[] { 1, 3, 1, 2, 0, 5 }, 3, new int[] { 3, 3, 2, 5 })]
        [TestCase(new int[] { -7, -8, 7, 5, 7, 1, 6, 0 }, 4, new int[] { 7, 7, 7, 7, 7 })]
        public void MaxSlidingWindow_Version1(int[] nums, int k, int[] expected)
        {
            var solution = new Solution0239();
            var actual = solution.MaxSlidingWindow_Version1(nums, k);

            actual.Should().BeEquivalentTo(expected);
        }
        
        [TestCase(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3, new int[] { 3, 3, 5, 5, 6, 7 })]
        [TestCase(new int[] { 1 }, 1, new int[] { 1 })]
        [TestCase(new int[] { 1, -1 }, 1, new int[] { 1, -1 })]
        [TestCase(new int[] { 9, 11 }, 2, new int[] { 11 })]
        [TestCase(new int[] { 4, -2 }, 2, new int[] { 4 })]
        [TestCase(new int[] { 1, 3, 1, 2, 0, 5 }, 3, new int[] { 3, 3, 2, 5 })]
        [TestCase(new int[] { -7, -8, 7, 5, 7, 1, 6, 0 }, 4, new int[] { 7, 7, 7, 7, 7 })]
        public void MaxSlidingWindow_Version2(int[] nums, int k, int[] expected)
        {
            var solution = new Solution0239();
            var actual = solution.MaxSlidingWindow_Version2(nums, k);

            actual.Should().BeEquivalentTo(expected);
        }
        
        [TestCase(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3, new int[] { 3, 3, 5, 5, 6, 7 })]
        [TestCase(new int[] { 1 }, 1, new int[] { 1 })]
        [TestCase(new int[] { 1, -1 }, 1, new int[] { 1, -1 })]
        [TestCase(new int[] { 9, 11 }, 2, new int[] { 11 })]
        [TestCase(new int[] { 4, -2 }, 2, new int[] { 4 })]
        [TestCase(new int[] { 1, 3, 1, 2, 0, 5 }, 3, new int[] { 3, 3, 2, 5 })]
        [TestCase(new int[] { -7, -8, 7, 5, 7, 1, 6, 0 }, 4, new int[] { 7, 7, 7, 7, 7 })]
        public void MaxSlidingWindow_Version3(int[] nums, int k, int[] expected)
        {
            var solution = new Solution0239();
            var actual = solution.MaxSlidingWindow_Version3(nums, k);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}