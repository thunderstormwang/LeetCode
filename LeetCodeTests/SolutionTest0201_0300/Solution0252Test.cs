using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0252Test
{
    [TestCaseSource(nameof(TestCases))]
    public void OOOTest(int[][] nums, bool expected)
    {
        var solution = new Solution0252();
        var actual = solution.CanAttendMeetings(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 },
            },
            false
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 7,10 },
                new int[] { 2,4 }
            },
            true
        }
    };
}