using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0039Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CombinationSum(int[] inputArray, int target, int[][] expectedArray)
    {
        var solution = new Solution0039();
        var actual = solution.CombinationSum(inputArray, target);

        actual.Should().BeEquivalentTo(expectedArray);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 2 },
            1,
            new int[][] { }
        },
        new object[]
        {
            new int[] { 2 },
            2,
            new int[][]
            {
                new int[] { 2 }
            },
        },
        new object[]
        {
            new int[] { 2, 3 },
            5,
            new int[][]
            {
                new int[] { 2, 3 }
            },
        },
        new object[]
        {
            new int[] { 2, 3, 5 },
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
            new int[] { 2, 3, 6, 7 },
            7,
            new int[][]
            {
                new int[] { 2, 2, 3 },
                new int[] { 7 }
            },
        }
    };
}