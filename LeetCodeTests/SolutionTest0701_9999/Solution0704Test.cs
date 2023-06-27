using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0704Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Search_Recursive(int[] nums, int target, int expected)
    {
        var solution = new Solution0704();
        var actual = solution.Search_Recursive(nums, target);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void Search_Iterative(int[] nums, int target, int expected)
    {
        var solution = new Solution0704();
        var actual = solution.Search_Iterative(nums, target);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { -1, 0, 3, 5, 9, 12 },
            9,
            4
        },
        new object[]
        {
            new int[] { -1, 0, 3, 5, 9, 12 },
            2,
            -1
        },
        new object[]
        {
            new int[] { 5 },
            5,
            0
        },
        new object[]
        {
            new int[] { 5 },
            -5,
            -1
        }
    };
}