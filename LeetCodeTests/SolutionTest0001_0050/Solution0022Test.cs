using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0022Test
{
    [TestCaseSource(nameof(TestCases))]
    public void GenerateParenthesis_Ver1Test(int input, string[] expected)
    {
        var solution = new Solution0022();
        var actual = solution.GenerateParenthesis_Ver1(input);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void GenerateParenthesis_Ver2Test(int input, string[] expected)
    {
        var solution = new Solution0022();
        var actual = solution.GenerateParenthesis_Ver3(input);

        actual.Should().BeEquivalentTo(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void GenerateParenthesis_Ver3Test(int input, string[] expected)
    {
        var solution = new Solution0022();
        var actual = solution.GenerateParenthesis_Ver2(input);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            1,
            new string[] { "()" }
        },
        new object[]
        {
            2,
            new string[] { "(())", "()()" }
        },
        new object[]
        {
            3,
            new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" }
        },
    };
}