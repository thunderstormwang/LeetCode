using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0017Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LetterCombinations_Ver1Test(string input, string[] expectedArray)
    {
        var solution017 = new Solution0017();
        var actual = solution017.LetterCombinations_Ver1(input);

        actual.Should().BeEquivalentTo(expectedArray);
    }

    [TestCaseSource(nameof(TestCases))]
    public void LetterCombinations_Ver2Test(string input, string[] expectedArray)
    {
        var solution = new Solution0017();
        var actual = solution.LetterCombinations_Ver2(input);

        actual.Should().BeEquivalentTo(expectedArray);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "23",
            new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" }
        },
        new object[]
        {
            string.Empty,
            new string[] { }
        },
        new object[]
        {
            "2",
            new string[] { "a", "b", "c" }
        }
    };
}