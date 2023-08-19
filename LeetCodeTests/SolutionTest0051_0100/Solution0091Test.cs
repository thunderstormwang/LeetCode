using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0091Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NumDecodings_Ver1Test(string s, int expected)
    {
        var solution = new Solution0091();

        var actual = solution.NumDecodings_Ver1(s);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void NumDecodings_Ver2Test(string s, int expected)
    {
        var solution = new Solution0091();

        var actual = solution.NumDecodings_Ver2(s);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "12",
            2
        },
        new object[]
        {
            "226",
            3
        },
        new object[]
        {
            "06",
            0
        },
        new object[]
        {
            "2101",
            1
        },
        new object[]
        {
            "1123",
            5
        },
        new object[]
        {
            "10011",
            0
        },
        new object[]
        {
            "230",
            0
        },
        new object[]
        {
            "27",
            1
        }
    };
}