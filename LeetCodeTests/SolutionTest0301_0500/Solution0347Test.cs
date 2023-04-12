using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500
{
    [TestFixture]
    [Category("SolutionTest0301_0500")]
    public class Solution0347Test
    {
        [TestCase(new int[] { 1, 1, 1, 2, 2, 3 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, 1, new int[] { 1 })]
        [TestCase(new int[] { 3, 0, 1, 0 }, 1, new int[] { 0 })]
        [TestCase(new int[] { -1, 1, 4, -4, 3, 5, 4, -2, 3, -1 }, 3, new int[] { -1, 3, 4 })]
        [TestCase(new int[] { 4, 1, -1, 2, -1, 2, 3 }, 2, new int[] { -1, 2 })]
        public void TopKFrequent_SortedSetTest(int[] nums, int k, int[] expected)
        {
            var solution = new Solution0347();
            var actual = solution.TopKFrequentTest_SortedSet(nums, k);

            actual.Should().BeEquivalentTo(expected);
        }

        [TestCase(new int[] { 1, 1, 1, 2, 2, 3 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 1 }, 1, new int[] { 1 })]
        [TestCase(new int[] { 3, 0, 1, 0 }, 1, new int[] { 0 })]
        [TestCase(new int[] { -1, 1, 4, -4, 3, 5, 4, -2, 3, -1 }, 3, new int[] { -1, 3, 4 })]
        [TestCase(new int[] { 4, 1, -1, 2, -1, 2, 3 }, 2, new int[] { -1, 2 })]
        public void TopKFrequent_HeapArrayTest(int[] nums, int k, int[] expected)
        {
            var solution = new Solution0347();
            var actual = solution.TopKFrequentTest_HeapArray(nums, k);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}