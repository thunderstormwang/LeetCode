using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

public class Solution0134Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CanCompleteCircuit_Brutal(int[] gas, int[] cost, int expected)
    {
        var solution = new Solution0134();
        var actual = solution.CanCompleteCircuit_Brutal(gas, cost);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void CanCompleteCircuit_Greedy(int[] gas, int[] cost, int expected)
    {
        var solution = new Solution0134();
        var actual = solution.CanCompleteCircuit_Greedy(gas, cost);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 3, 4, 5, 1, 2 },
            3
        },
        new object[]
        {
            new int[] { 2, 3, 4 },
            new int[] { 3, 4, 3 },
            -1
        },
        new object[]
        {
            new int[] { 4, 5, 2, 6, 5, 3 },
            new int[] { 3, 2, 7, 3, 2, 9 },
            -1
        }
    };
}