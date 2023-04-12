using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0474Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindMaxForm_Ver1Test(string[] strs, int m, int n, int expected)
    {
        var solution = new Solution0474();
        var actual = solution.FindMaxForm_Ver1(strs, m, n);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void FindMaxForm_Ver2Test(string[] strs, int m, int n, int expected)
    {
        var solution = new Solution0474();
        var actual = solution.FindMaxForm_Ver2(strs, m, n);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new string[] { "10", "0001", "111001", "1", "0" },
            5,
            3,
            4
        },
        new object[]
        {
            new string[] { "10", "0", "1" },
            1,
            1,
            2
        }
    };
}