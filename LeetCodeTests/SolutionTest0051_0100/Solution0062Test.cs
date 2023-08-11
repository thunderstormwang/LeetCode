using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0062Test
{
    [TestCaseSource(nameof(TestCases))]
    public void UniquePaths_Ver1Test(int m, int n, int expected)
    {
        var solution = new Solution0062();
        var actual = solution.UniquePaths_Ver1(m, n);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void UniquePaths_Ver2Test(int m, int n, int expected)
    {
        var solution = new Solution0062();
        var actual = solution.UniquePaths_Ver2(m, n);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            3,
            2,
            3
        },
        new object[]
        {
            3,
            7,
            28
        },
        new object[]
        {
            1,
            1,
            1
        },
        new object[]
        {
            10,
            10,
            48620
        }
    };
}