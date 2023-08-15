using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0221Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindOrder_Ver2Test(char[][] matrix, int expected)
    {
        var solution = new Solution0221();

        var actual = solution.MaximalSquare(matrix);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new char[][]
            {
                new char[] { '1', '0', '1', '0', '0' },
                new char[] { '1', '0', '1', '1', '1' },
                new char[] { '1', '1', '1', '1', '1' },
                new char[] { '1', '0', '0', '1', '0' }
            },
            4
        },
        new object[]
        {
            new char[][]
            {
                new char[] { '0', '1' },
                new char[] { '1', '0' }
            },
            1
        },
        new object[]
        {
            new char[][]
            {
                new char[] { '0' }
            },
            0
        }
    };
}