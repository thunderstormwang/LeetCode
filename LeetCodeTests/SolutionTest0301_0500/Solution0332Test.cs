using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

public class Solution0332Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LevelOrder(IList<IList<string>> tickets, List<string> expected)
    {
        var solution = new Solution0332();
        var actual = solution.FindItinerary(tickets);

        actual.Should().Equal(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new List<IList<string>>
            {
                new List<string> { "MUC", "LHR" },
                new List<string> { "JFK", "MUC" },
                new List<string> { "SFO", "SJC" },
                new List<string> { "LHR", "SFO" }
            },
            new List<string> { "JFK", "MUC", "LHR", "SFO", "SJC" }
        },
        new object[]
        {
            new List<IList<string>>
            {
                new List<string> { "JFK", "SFO" },
                new List<string> { "JFK", "ATL" },
                new List<string> { "SFO", "ATL" },
                new List<string> { "ATL", "JFK" },
                new List<string> { "ATL", "SFO" }
            },
            new List<string> { "JFK", "ATL", "JFK", "SFO", "ATL", "SFO" }
        }
    };
}