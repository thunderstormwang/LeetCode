using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0050Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MyPow_Ver1Test(double x, int n, double expected)
    {
        var solution = new Solution0050();

        var actual = solution.MyPow_Ver1(x, n);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MyPow_Ver2Test(double x, int n, double expected)
    {
        var solution = new Solution0050();

        var actual = solution.MyPow_Ver2(x, n);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            2d,
            10,
            1024d
        },
        new object[]
        {
            2d,
            -2,
            0.25d
        },
        new object[]
        {
            2d,
            0,
            1d
        },
        new object[]
        {
            1d,
            -2147483648,
            1d
        }
    };
}