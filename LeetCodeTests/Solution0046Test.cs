using System.Collections.Generic;
using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0046Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void Permute_IterativeTest(int[] input,
            int[][] expectedArray)
        {
            var solution = new Solution0046();
            var expectList = new List<List<int>>();
            foreach (var array in expectedArray)
            {
                expectList.Add(new List<int>(array));
            }

            var actual = solution.Permute_Iterative(input);

            actual.Should().BeEquivalentTo(expectList);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void Permute_RecursiveTest(int[] input,
            int[][] expectedArray)
        {
            var solution046 = new Solution0046();
            var expectList = new List<List<int>>();
            foreach (var array in expectedArray)
            {
                expectList.Add(new List<int>(array));
            }

            var actual = solution046.Permute_Recursive(input);

            actual.Should().BeEquivalentTo(expectList);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[] { 0 },
                new int[][] { new int[] { 0 } }
            },
            new object[]
            {
                new int[] { 0, 1 },
                new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 } }
            },
            new object[]
            {
                new int[] { 0, 1, 2 },
                new int[][]
                {
                    new int[] { 2, 0, 1 }, new int[] { 0, 2, 1 }, new int[] { 0, 1, 2 },
                    new int[] { 2, 1, 0 }, new int[] { 1, 2, 0 }, new int[] { 1, 0, 2 }
                }
            }
        };
    }
}