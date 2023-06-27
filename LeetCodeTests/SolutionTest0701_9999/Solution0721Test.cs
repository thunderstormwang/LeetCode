using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0721Test
{
    [TestCaseSource(nameof(TestCases))]
    public void AccountsMerge_Ver1Test(IList<IList<string>> accounts, IList<IList<string>> expected)
    {
        var solution = new Solution0721();
        var actual = solution.AccountsMerge_Ver1(accounts);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void AccountsMerge_Ver2Test(IList<IList<string>> accounts, IList<IList<string>> expected)
    {
        var solution = new Solution0721();
        var actual = solution.AccountsMerge_Ver2(accounts);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new List<IList<string>>()
            {
                new List<string>() { "John", "johnsmith@mail.com", "john_newyork@mail.com" },
                new List<string>() { "John", "johnsmith@mail.com", "john00@mail.com" },
                new List<string>() { "Mary", "mary@mail.com" },
                new List<string>() { "John", "johnnybravo@mail.com" }
            },
            new List<IList<string>>()
            {
                new List<string>() { "John", "john00@mail.com", "john_newyork@mail.com", "johnsmith@mail.com" },
                new List<string>() { "Mary", "mary@mail.com" },
                new List<string>() { "John", "johnnybravo@mail.com" }
            }
        },
        new object[]
        {
            new List<IList<string>>()
            {
                new List<string>() { "Gabe", "Gabe0@m.co", "Gabe3@m.co", "Gabe1@m.co" },
                new List<string>() { "Kevin", "Kevin3@m.co", "Kevin5@m.co", "Kevin0@m.co" },
                new List<string>() { "Ethan", "Ethan5@m.co", "Ethan4@m.co", "Ethan0@m.co" },
                new List<string>() { "Hanzo", "Hanzo3@m.co", "Hanzo1@m.co", "Hanzo0@m.co" },
                new List<string>() { "Fern", "Fern5@m.co", "Fern1@m.co", "Fern0@m.co" }
            },
            new List<IList<string>>()
            {
                new List<string>() { "Gabe", "Gabe0@m.co", "Gabe3@m.co", "Gabe1@m.co" },
                new List<string>() { "Kevin", "Kevin3@m.co", "Kevin5@m.co", "Kevin0@m.co" },
                new List<string>() { "Ethan", "Ethan5@m.co", "Ethan4@m.co", "Ethan0@m.co" },
                new List<string>() { "Hanzo", "Hanzo3@m.co", "Hanzo1@m.co", "Hanzo0@m.co" },
                new List<string>() { "Fern", "Fern5@m.co", "Fern1@m.co", "Fern0@m.co" }
            }
        },
    };
}