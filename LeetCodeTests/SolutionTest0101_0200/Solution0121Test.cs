using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0121Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void MaxProfit_BrutalTest(int[] prices, int expected)
        {
            var solution = new Solution0121();

            var actual = solution.MaxProfit_Brutal(prices);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void MaxProfit_GreedyTest(int[] prices, int expected)
        {
            var solution = new Solution0121();

            var actual = solution.MaxProfit_Greedy(prices);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void MaxProfit_DPTest(int[] array, int expected)
        {
            var solution = new Solution0121();

            var actual = solution.MaxProfit_DP(array);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[] { 7, 1, 5, 3, 6, 4 },
                5
            },
            new object[]
            {
                new int[] {  7, 6, 4, 3, 1 },
                0
            }
        };
    }
}