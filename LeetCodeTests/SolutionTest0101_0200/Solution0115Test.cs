using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
[Category("SolutionTest0101_0200")]
public class Solution0115Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NumDistinct_Ver1Test(string s, string t, int expected)
    {
        var solution = new Solution0115();
        var actual = solution.NumDistinct_Ver1(s, t);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void NumDistinct_Ver2Test(string s, string t, int expected)
    {
        var solution = new Solution0115();
        var actual = solution.NumDistinct_Ver2(s, t);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "rabbbit",
            "rabbit",
            3
        },
        new object[]
        {
            "babgbag",
            "bag",
            5
        }
    };
}