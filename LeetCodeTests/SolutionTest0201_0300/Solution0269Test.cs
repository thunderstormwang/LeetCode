using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0269Test
{
    [TestCaseSource(nameof(TestCases))]
    public void AlienOrder_Ver1Test(string[] words, string expected)
    {
        var solution = new Solution0269();
        var actual = solution.AlienOrder_Ver1(words);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void AlienOrder_Ver3Test(string[] words, string expected)
    {
        var solution = new Solution0269();
        var actual = solution.AlienOrder_Ver2(words);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new string[] { "wrt", "wrf", "er", "ett", "rftt" },
            "wertf"
        },
        new object[]
        {
            new string[] { "z", "x" },
            "zx"
        },
        new object[]
        {
            new string[] { "z", "x", "z" },
            ""
        }
    };
}