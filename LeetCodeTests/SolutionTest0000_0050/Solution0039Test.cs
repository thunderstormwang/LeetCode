using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Solution0000_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0000_0050
{
    [TestFixture]
    public class Solution0039Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void CombinationSum(int[] inputArray,
            int target,
            int[][] expectedArray)
        {
            var solution = new Solution0039();
            var actual = solution.CombinationSum(inputArray,
                target);
            var expected = new List<List<int>>();
            foreach (var item in expectedArray)
            {
                expected.Add(new List<int>(item));
            }

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[]
                {
                    2
                },
                1,
                new int[][]
                {
                }
            },
            new object[]
            {
                new int[]
                {
                    2
                },
                2,
                new int[][]
                {
                    new int[] { 2 }
                },
            },
            new object[]
            {
                new int[]
                {
                    2, 3
                },
                5,
                new int[][]
                {
                    new int[] { 2, 3 }
                },
            },
            new object[]
            {
                new int[]
                {
                    2, 3, 5
                },
                8,
                new int[][]
                {
                    new int[] { 2, 2, 2, 2 },
                    new int[] { 2, 3, 3 },
                    new int[] { 3, 5 }
                },
            },
            new object[]
            {
                new int[]
                {
                    2, 3, 6, 7
                },
                7,
                new int[][]
                {
                    new int[] { 2, 2, 3 },
                    new int[] { 7 }
                },
            }
        };
    }
}