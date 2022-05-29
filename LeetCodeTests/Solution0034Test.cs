using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0034Test
    {
        [TestCase(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 })]
        [TestCase(new int[] { 5, 7, 7, 8, 8, 10 }, 6, new int[] { -1, -1 })]
        [TestCase(new int[] { 1 }, 1, new int[] { 0, 0 })]
        [TestCase(new int[] { }, 0, new int[] { -1, -1 })]
        public void SearchRange_RecursiveTest(int[] array, int val, int[] expected)
        {
            var solution = new Solution0034();
            var actual = solution.SearchRange_Recursive(array, val);

            actual.Should().BeEquivalentTo(expected);
        }

        [TestCase(new int[] { 5, 7, 7, 8, 8, 10 }, 8, new int[] { 3, 4 })]
        [TestCase(new int[] { 5, 7, 7, 8, 8, 10 }, 6, new int[] { -1, -1 })]
        [TestCase(new int[] { 1 }, 1, new int[] { 0, 0 })]
        [TestCase(new int[] { }, 0, new int[] { -1, -1 })]
        public void SearchRange_IterativeTest(int[] array, int val, int[] expected)
        {
            var solution = new Solution0034();
            var actual = solution.SearchRange_Iterative(array, val);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}