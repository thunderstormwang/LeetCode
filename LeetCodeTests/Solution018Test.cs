using System.Collections.Generic;
using FluentAssertions;
using LeetCode;
using LeetCode.Properties;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution018Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void FourSumTest(int[] input,
            int target,
            int[][] expectedArray)
        {
            var solution018 = new Solution018();
            var expectList = new List<List<int>>();
            foreach (var array in expectedArray)
            {
                expectList.Add(new List<int>(array));
            }

            var actual = solution018.FourSum(input,
                target);

            actual.Should().BeEquivalentTo(expectList);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[] { 1, 0, -1, 0, -2, 2 },
                0,
                new int[][] { new int[] { -2, -1, 1, 2 }, new int[] { -2, 0, 0, 2 }, new int[] { -1, 0, 0, 1 } }
            },
            new object[]
            {
                new int[] { 2, 2, 2, 2, 2 },
                8,
                new int[][] { new int[] { 2, 2, 2, 2 } }
            }
        };
    }
}