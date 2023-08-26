using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0007Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Reverse_Ver1Test(int input, int expected)
    {
        var solution = new Solution0007();

        var actual = solution.Reverse_Ver1(input);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void Reverse_Ver2Test(int input, int expected)
    {
        var solution = new Solution0007();

        var actual = solution.Reverse_Ver2(input);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            123,
            321
        },
        new object[]
        {
            -123,
            -321
        },
        new object[]
        {
            120,
            21
        },
        new object[]
        {
            0,
            0
        },
        new object[]
        {
            1534236469,
            0
        },
        new object[]
        {
            -2147483648,
            0
        }
    };
}