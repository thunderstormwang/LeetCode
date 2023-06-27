using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0583Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MinDistance_Ver1Test(string word1, string word2, int expected)
    {
        var solution = new Solution0583();
        var actual = solution.MinDistance_Ver1(word1, word2);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MinDistance_Ver2Test(string word1, string word2, int expected)
    {
        var solution = new Solution0583();
        var actual = solution.MinDistance_Ver2(word1, word2);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MinDistance_Ver3Test(string word1, string word2, int expected)
    {
        var solution = new Solution0583();
        var actual = solution.MinDistance_Ver3(word1, word2);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MinDistance_Ver4Test(string word1, string word2, int expected)
    {
        var solution = new Solution0583();
        var actual = solution.MinDistance_Ver4(word1, word2);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "sea",
            "eat",
            2
        },
        new object[]
        {
            "leetcode",
            "etco",
            4
        },
        new object[]
        {
            "a",
            "b",
            2
        }
    };
}