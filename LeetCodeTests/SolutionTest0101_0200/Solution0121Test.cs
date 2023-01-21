using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0121Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void MaxProfit_BrutalTest(int[] array, int expected)
        {
            var solution = new Solution0121();

            var actual = solution.MaxProfit_Brutal(array);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void MaxProfit_GreedyTest(int[] array, int expected)
        {
            var solution = new Solution0121();

            var actual = solution.MaxProfit_Greedy(array);

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