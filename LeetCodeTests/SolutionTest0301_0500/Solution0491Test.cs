using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
public class Solution0491Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindSubsequencesTest(int[] inputArray, int[][] expectedArray)
    {
        var solution = new Solution0491();
        var actual = solution.FindSubsequences(inputArray);

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
            new int[] { 4, 6, 7, 7 },
            new int[][]
            {
                new int[] { 4, 6 },
                new int[] { 4, 6, 7 },
                new int[] { 4, 6, 7, 7 },
                new int[] { 4, 7 },
                new int[] { 4, 7, 7 },
                new int[] { 6, 7 },
                new int[] { 6, 7, 7 },
                new int[] { 7, 7 },
            }
        },
        new object[]
        {
            new int[] { 4, 4, 3, 2, 1 },
            new int[][]
            {
                new int[] { 4, 4 }
            }
        },
        new object[]
        {
            new int[] { 4, 4, 3, 4 },
            new int[][]
            {
                new int[] { 4, 4 },
                new int[] { 4, 4, 4 },
                new int[] { 3, 4 }
            }
        },
        new object[]
        {
            new int[] { 4, 6, 4, 6 },
            new int[][]
            {
                new int[] { 4, 4 },
                new int[] { 4, 6 },
                new int[] { 6, 6 },
                new int[] { 4, 4, 6 },
                new int[] { 4, 6, 6 }
            }
        }
    };
}