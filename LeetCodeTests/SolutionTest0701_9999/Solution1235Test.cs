using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution1235Test
{
    [TestCaseSource(nameof(TestCases))]
    public void JobScheduling_Ver1Test(int[] startTime, int[] endTime, int[] profit, int expected)
    {
        var solution = new Solution1235();
        var actual = solution.JobScheduling_Ver1(startTime, endTime, profit);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void JobScheduling_Ver2Test(int[] startTime, int[] endTime, int[] profit, int expected)
    {
        var solution = new Solution1235();
        var actual = solution.JobScheduling_Ver2(startTime, endTime, profit);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void JobScheduling_Ver3Test(int[] startTime, int[] endTime, int[] profit, int expected)
    {
        var solution = new Solution1235();
        var actual = solution.JobScheduling_Ver3(startTime, endTime, profit);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 3 },
            new int[] { 3, 4, 5, 6 },
            new int[] { 50, 10, 40, 70 },
            120
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 6 },
            new int[] { 3, 5, 10, 6, 9 },
            new int[] { 20, 20, 100, 70, 60 },
            150
        },
        new object[]
        {
            new int[] { 1, 1, 1 },
            new int[] { 2, 3, 4 },
            new int[] { 5, 6, 4 },
            6
        }
    };
}