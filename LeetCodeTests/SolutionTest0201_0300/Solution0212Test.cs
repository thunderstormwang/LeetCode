using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0212Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SubsetsTest(char[][] board, string[] word, IList<string> expeted)
    {
        var solution = new Solution0212();
        var actual = solution.FindWords(board, word);

        actual.Should().BeEquivalentTo(expeted);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new char[][]
            {
                new char[] { 'o', 'a', 'a', 'n', 'n' },
                new char[] { 'e', 't', 'a', 'e', 'e' },
                new char[] { 'i', 'h', 'k', 'r', 'i' },
                new char[] { 'i', 'f', 'l', 'v', 'v' }
            },
            new string[] { "oath", "pea", "eat", "rain" },
            new string[] { "eat", "oath" }
        },
        new object[]
        {
            new char[][]
            {
                new char[] { 'a', 'b' },
                new char[] { 'c', 'd' }
            },
            new string[] { "abcb" },
            new string[] { }
        }
    };
}