using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0739Test
{
    [TestCaseSource(nameof(TestCases))]
    public void DailyTemperatures_BrutalTest(int[] temperatures, int[] expected)
    {
        var solution = new Solution0739();
        var actual = solution.DailyTemperatures_Brutal(temperatures);

        actual.Should().Equal(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void DailyTemperatures_StackTest(int[] temperatures, int[] expected)
    {
        var solution = new Solution0739();
        var actual = solution.DailyTemperatures_Stack(temperatures);

        actual.Should().Equal(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 73, 74, 75, 71, 69, 72, 76, 73 },
            new int[] { 1, 1, 4, 2, 1, 1, 0, 0 }
        },
        new object[]
        {
            new int[] { 30, 40, 50, 60 },
            new int[] { 1, 1, 1, 0 }
        },
        new object[]
        {
            new int[] { 30, 60, 90 },
            new int[] { 1, 1, 0 }
        },
        new object[]
        {
            new int[] { 55, 38, 53, 81, 61, 93, 97, 32, 43, 78 },
            new int[] { 3, 1, 1, 2, 1, 1, 0, 1, 1, 0 }
        }
    };
}