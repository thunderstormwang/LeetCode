using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Properties;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0015Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void ThreeSumTest(int[] input,
            int[][] expectedArray)
        {
            var solution = new Solution0015();
            var expectList = new List<List<int>>();
            foreach (var array in expectedArray)
            {
                expectList.Add(new List<int>(array));
            }

            var actual = solution.ThreeSum(input);

            actual.Should().BeEquivalentTo(expectList);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[] { -1, 0, 1, 2, -1, -4 },
                new int[][] { new int[] { -1, -1, 2 }, new int[] { -1, 0, 1 } }
            },
            new object[]
            {
                new int[] { 0 },
                new int[][] { }
            }
        };
    }
}