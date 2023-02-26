using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
public class Solution0674Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindLengthOfLCIS_DPTest(int[] nums, int expected)
    {
        var solution = new Solution0674();

        var actual = solution.FindLengthOfLCIS_DP(nums);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void FindLengthOfLCIS_GreedyTest(int[] nums, int expected)
    {
        var solution = new Solution0674();

        var actual = solution.FindLengthOfLCIS_Greedy(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 3, 5, 4, 7 },
            3
        },
        new object[]
        {
            new int[] { 2, 2, 2, 2, 2 },
            1
        },
        new object[]
        {
            new int[] { 1, 3, 5, 7 },
            4
        }
    };
}