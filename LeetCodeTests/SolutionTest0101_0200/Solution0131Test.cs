using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
[Category("SolutionTest0101_0200")]
public class Solution0131Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Partition_IndexAndLength(string s, IList<IList<string>> expected)
    {
        var solution = new Solution0131();
        var actual = solution.Partition_IndexAndLength(s);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void Partition_Index(string s, IList<IList<string>> expected)
    {
        var solution = new Solution0131();
        var actual = solution.Partition_Index(s);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "aab",
            new List<IList<string>>
            {
                new List<string>() { "a", "a", "b" },
                new List<string>() { "aa", "b" },
            }
        },
        new object[]
        {
            "a",
            new List<IList<string>>
            {
                new List<string>() { "a" }
            }
        },
        new object[]
        {
            "aabb",
            new List<IList<string>>
            {
                new List<string>() { "a", "a", "b", "b" },
                new List<string>() { "a", "a", "bb" },
                new List<string>() { "aa", "b", "b" },
                new List<string>() { "aa", "bb" }
            }
        },
        new object[]
        {
            "efe",
            new List<IList<string>>
            {
                new List<string>() { "e", "f", "e" },
                new List<string>() { "efe" }
            }
        }
    };
}