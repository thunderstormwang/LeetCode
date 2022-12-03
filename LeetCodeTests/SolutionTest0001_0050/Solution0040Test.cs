using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    public class Solution0040Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void CombinationSum2(int[] inputArray, int target, int[][] expectedArray)
        {
            var solution = new Solution0040();
            var actual = solution.CombinationSum2(inputArray, target);

            actual.Should().BeEquivalentTo(expectedArray);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[] { 10, 1, 2, 7, 6, 1, 5 },
                8,
                new int[][]
                {
                    new int[] { 1, 1, 6 },
                    new int[] { 1, 2, 5 },
                    new int[] { 1, 7 },
                    new int[] { 2, 6 }
                }
            },
            new object[]
            {
                new int[] { 2, 5, 2, 1, 2 },
                5,
                new int[][]
                {
                    new int[] { 1, 2, 2 },
                    new int[] { 5 }
                },
            },
            new object[]
            {
                new int[] { 2, 2, 2, 2 },
                6,
                new int[][]
                {
                    new int[] { 2, 2, 2 }
                },
            }
        };
    }
}