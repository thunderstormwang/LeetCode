using FluentAssertions;
using LeetCode.Solution0201_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_9999
{
    [TestFixture]
    public class Solution0347Test
    {
        [TestCase(new int[] { 1, 1, 1, 2, 2, 3 },
            2,
            new int[] { 1, 2 })]
        [TestCase(new int[] { 1 },
            1,
            new int[] { 1 })]
        [TestCase(new int[] { 3,0,1,0 },
            1,
            new int[] { 0 })]
        public void TopKFrequent(int[] nums,
            int k,
            int[] expected)
        {
            var solution = new Solution0347();
            var actual = solution.TopKFrequentTest(nums,
                k);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}