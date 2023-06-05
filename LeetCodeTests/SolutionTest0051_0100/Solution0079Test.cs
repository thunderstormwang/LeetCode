using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0079Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SubsetsTest(char[][] board, string word, bool expeted)
    {
        var solution = new Solution0079();
        var actual = solution.Exist(board, word);

        actual.Should().Be(expeted);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            },
            "ABCCED",
            true
        },
        new object[]
        {
            new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            },
            "SEE",
            true
        },
        new object[]
        {
            new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            },
            "ABCB",
            false
        }
    };
}