using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0261Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CanAttendMeetingsTest(int n, int[][] edges, bool expected)
    {
        var solution = new Solution0261();
        var actual = solution.ValidTree(n, edges);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            5,
            new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 0, 3 },
                new int[] { 1, 4 },
            },
            true
        },
        new object[]
        {
            5,
            new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 1, 3 },
                new int[] { 1, 4 },
            },
            false
        }
    };
}