using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
public class Solution0051Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SolveNQueens(int n, IList<IList<string>> expected)
    {
        var solution = new Solution0051();
        var actual = solution.SolveNQueens(n);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void SolveNQueens_1Dim(int n, IList<IList<string>> expected)
    {
        var solution = new Solution0051();
        var actual = solution.SolveNQueens_1Dim(n);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            1,
            new string[][]
            {
                new string[] { "Q" }
            }
        },
        new object[]
        {
            2,
            new string[][] { }
        },
        new object[]
        {
            3,
            new string[][] { }
        },
        new object[]
        {
            4,
            new string[][]
            {
                new string[] { ".Q..", "...Q", "Q...", "..Q." },
                new string[] { "..Q.", "Q...", "...Q", ".Q.." },
            }
        },
    };
}