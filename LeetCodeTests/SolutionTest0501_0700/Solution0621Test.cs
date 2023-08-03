using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0621Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LeastInterval_Ver1Test(char[] tasks, int n, int expected)
    {
        var solution = new Solution0621();

        var actual = solution.LeastInterval_Ver1(tasks, n);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void LeastInterval_Ver2Test(char[] tasks, int n, int expected)
    {
        var solution = new Solution0621();

        var actual = solution.LeastInterval_Ver2(tasks, n);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new char[] {'A','A','A','B','B','B' },
            2,
            8
        },
        new object[]
        {
            new char[] {'A','A','A','B','B','B' },
            0,
            6
        },
        new object[]
        {
            new char[] {'A','A','A','A','A','A','B','C','D','E','F','G' },
            2,
            16
        },
        new object[]
        {
            new char[] {'A','A','A','A','A','B','B','B','B','C','C','C','C' },
            1,
            13
        },
        new object[]
        {
            new char[] {'A','A','A','A','A','B','B','B','B','C','C','C','C' },
            2,
            13
        }
    };
}