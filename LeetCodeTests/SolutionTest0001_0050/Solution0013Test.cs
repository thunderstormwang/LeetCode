using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0013Test
{
    [TestCaseSource(nameof(TestCases))]
    public void RomanToInt_Ver1Test(string input, int expected)
    {
        var solution = new Solution0013();

        var actual = solution.RomanToInt_Ver1(input);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void RomanToInt_Ver2Test(string input, int expected)
    {
        var solution = new Solution0013();

        var actual = solution.RomanToInt_Ver2(input);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "III",
            3
        },
        new object[]
        {
            "IV",
            4
        },
        new object[]
        {
            "IX",
            9
        },
        new object[]
        {
            "LVIII",
            58
        },
        new object[]
        {
            "MCMXCIV",
            1994
        },
        new object[]
        {
            "MMMCMXCIX",
            3999
        },
        new object[]
        {
            "MMCM",
            2900
        }
    };
}