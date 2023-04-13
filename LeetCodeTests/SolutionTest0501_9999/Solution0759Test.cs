using FluentAssertions;
using LeetCode.Models;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution0759Test
{
    [TestCaseSource(nameof(TestCases))]
    public void PartitionLabelsTest(List<List<Interval>> schedules, List<Interval> expected)
    {
        var solution = new Solution0759();
        var actual = solution.EmployeeFreeTime(schedules);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new List<List<Interval>>
            {
                new()
                {
                    new() { start = 1, end = 2 },
                    new() { start = 5, end = 6 }
                },
                new()
                {
                    new() { start = 1, end = 3 }
                },
                new()
                {
                    new() { start = 4, end = 10 }
                }
            },
            new List<Interval>()
            {
                new() { start = 3, end = 4 }
            }
        },
        new object[]
        {
            new List<List<Interval>>
            {
                new()
                {
                    new() { start = 1, end = 3 },
                    new() { start = 6, end = 7 }
                },
                new()
                {
                    new() { start = 2, end = 4 }
                },
                new()
                {
                    new() { start = 2, end = 5 },
                    new() { start = 9, end = 12 }
                }
            },
            new List<Interval>()
            {
                new() { start = 5, end = 6 },
                new() { start = 7, end = 9 }
            }
        }
    };
}