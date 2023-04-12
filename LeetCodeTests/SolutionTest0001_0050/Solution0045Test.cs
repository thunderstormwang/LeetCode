using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0045Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Jump_DynamicProgrammingTest(int[] nums,
        int expected)
    {
        var solution = new Solution0045();

        var actual = solution.Jump_DynamicProgramming(nums);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void Jump_GreedyTest(int[] nums, int expected)
    {
        var solution = new Solution0045();

        var actual = solution.Jump_Greedy(nums);

        actual.Should().Be(expected);
    }
    
    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 2, 3, 1, 1, 4 },
            2
        },
        new object[]
        {
            new int[] { 2, 3, 1, 0, 4 },
            2
        },
        new object[]
        {
            new int[] { 2, 1 },
            1
        },
        new object[]
        {
            new int[] { 2 },
            0
        }
    };
}