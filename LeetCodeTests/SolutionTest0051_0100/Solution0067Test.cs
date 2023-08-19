using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
public class Solution0067Test
{
    [TestCaseSource(nameof(TestCases))]
    public void AddBinary_Ver1Test(string a, string b, string expected)
    {
        var solution = new Solution0067();

        var actual = solution.AddBinary_Ver1(a, b);

        actual.Should().Be(expected);
    }
        
    [TestCaseSource(nameof(TestCases))]
    public void AddBinary_Ver2Test(string a, string b, string expected)
    {
        var solution = new Solution0067();

        var actual = solution.AddBinary_Ver2(a, b);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "11",
            "1",
            "100"
        },
        new object[]
        {
            "1010",
            "1011",
            "10101"
        }
    };
}