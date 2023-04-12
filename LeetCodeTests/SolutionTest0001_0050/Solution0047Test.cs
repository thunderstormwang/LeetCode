using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0047Test
{
    [TestCaseSource(nameof(TestCases))]
    public void PermuteUniqueTest(int[] nums, int[][] expectedArray)
    {
        var solution = new Solution0047();
        var actual = solution.PermuteUnique(nums);

        actual.Should().BeEquivalentTo(expectedArray);
    }

    [TestCaseSource(nameof(TestCases))]
    public void PermuteUnique_SwapTest(int[] nums, int[][] expectedArray)
    {
        var solution = new Solution0047();
        var actual = solution.PermuteUnique_Swap(nums);

        actual.Should().BeEquivalentTo(expectedArray);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 0 },
            new int[][]
            {
                new int[] { 0 }
            }
        },
        new object[]
        {
            new int[] { 1, 1, 1 },
            new int[][]
            {
                new int[] { 1, 1, 1 }
            }
        },
        new object[]
        {
            new int[] { 1, 1, 2 },
            new int[][]
            {
                new int[] { 1, 1, 2 },
                new int[] { 1, 2, 1 },
                new int[] { 2, 1, 1 }
            }
        },
        new object[]
        {
            new int[] { 0, 1, 2 },
            new int[][]
            {
                new int[] { 2, 0, 1 },
                new int[] { 0, 2, 1 },
                new int[] { 0, 1, 2 },
                new int[] { 2, 1, 0 },
                new int[] { 1, 2, 0 },
                new int[] { 1, 0, 2 }
            }
        },
        new object[]
        {
            new int[] { 1, 2, 3 },
            new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 3, 2 },
                new int[] { 2, 1, 3 },
                new int[] { 2, 3, 1 },
                new int[] { 3, 1, 2 },
                new int[] { 3, 2, 1 }
            }
        }
    };
}