using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0336Test
{
    [TestCaseSource(nameof(TestCases))]
    public void PalindromePairsTest(string[] words, IList<IList<int>> expected)
    {
        var solution = new Solution0336();
        var actual = solution.PalindromePairs(words);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new string[] { "abcd", "dcba", "lls", "s", "sssll" },
            new List<IList<int>>
            {
                new List<int> { 0, 1 },
                new List<int> { 1, 0 },
                new List<int> { 3, 2 },
                new List<int> { 2, 4 }
            }
        },
        new object[]
        {
            new string[] { "bat", "tab", "cat" },
            new List<IList<int>>
            {
                new List<int> { 0, 1 },
                new List<int> { 1, 0 }
            }
        },
        new object[]
        {
            new string[] { "a", "" },
            new List<IList<int>>
            {
                new List<int> { 0, 1 },
                new List<int> { 1, 0 }
            }
        },
        new object[]
        {
            new string[] { "bat", "tab" },
            new List<IList<int>>
            {
                new List<int> { 0, 1 },
                new List<int> { 1, 0 }
            }
        }
    };
}