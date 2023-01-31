using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500;

[TestFixture]
public class Solution0494Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindSubsequences_Ver1_1Test(int[] nums, int target, int expected)
    {
        var solution = new Solution0494();
        var actual = solution.FindTargetSumWays_Ver1_1(nums, target);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void FindSubsequences_Ver1_2Test(int[] nums, int target, int expected)
    {
        var solution = new Solution0494();
        var actual = solution.FindTargetSumWays_Ver1_2(nums, target);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void FindSubsequences_Ver2_1Test(int[] nums, int target, int expected)
    {
        var solution = new Solution0494();
        var actual = solution.FindTargetSumWays_Ver2_1(nums, target);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void FindSubsequences_Ver2_2Test(int[] nums, int target, int expected)
    {
        var solution = new Solution0494();
        var actual = solution.FindTargetSumWays_Ver2_2(nums, target);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 1, 1, 1, 1 },
            3,
            5
        },
        new object[]
        {
            new int[] { 1 },
            1,
            1
        },
        new object[]
        {
            new int[] { 1 },
            2,
            0
        },
        new object[]
        {
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            1,
            256
        }
    };
}