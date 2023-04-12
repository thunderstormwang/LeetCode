using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0072Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MinDistance_Ver1Test(string word1, string word2, int expected)
    {
        var solution = new Solution0072();

        var actual = solution.MinDistance_Ver1(word1, word2);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MinDistance_Ver2Test(string word1, string word2, int expected)
    {
        var solution = new Solution0072();

        var actual = solution.MinDistance_Ver2(word1, word2);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "horse",
            "ros",
            3
        },
        new object[]
        {
            "intention",
            "execution",
            5
        },
        new object[]
        {
            "b",
            "",
            1
        }
    };
}