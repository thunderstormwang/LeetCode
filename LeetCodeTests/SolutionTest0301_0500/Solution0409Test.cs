using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0409Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ReconstructQueueTest(string s, int expected)
    {
        var solution = new Solution0409();
        var actual = solution.LongestPalindrome(s);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "abccccdd",
            7
        },
        new object[]
        {
            "a",
            1
        },
        new object[]
        {
            "Aa",
            1
        }
    };

    [TestFixture]
    [Category("SolutionTest0301_0500")]
    public class Solution0406Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void ReconstructQueueTest(int[][] people, int[][] expected)
        {
            var solution = new Solution0406();
            var actual = solution.ReconstructQueue(people);

            actual.Should().HaveSameCount(expected);
            for (var i = 0; i < actual.Length; i++)
            {
                actual[i].Should().BeEquivalentTo(expected[i]);
            }
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[][]
                {
                    new int[] { 7, 0 },
                    new int[] { 4, 4 },
                    new int[] { 7, 1 },
                    new int[] { 5, 0 },
                    new int[] { 6, 1 },
                    new int[] { 5, 2 }
                },
                new int[][]
                {
                    new int[] { 5, 0 },
                    new int[] { 7, 0 },
                    new int[] { 5, 2 },
                    new int[] { 6, 1 },
                    new int[] { 4, 4 },
                    new int[] { 7, 1 }
                }
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 6, 0 },
                    new int[] { 5, 0 },
                    new int[] { 4, 0 },
                    new int[] { 3, 2 },
                    new int[] { 2, 2 },
                    new int[] { 1, 4 }
                },
                new int[][]
                {
                    new int[] { 4, 0 },
                    new int[] { 5, 0 },
                    new int[] { 2, 2 },
                    new int[] { 3, 2 },
                    new int[] { 1, 4 },
                    new int[] { 6, 0 }
                }
            }
        };
    }
}