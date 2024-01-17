using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0028Test
{
    [TestCaseSource(nameof(TestCases))]
    public void StrStr_Ver1Test(string haystack, string needle, int expected)
    {
        var solution = new Solution0028();

        var actual = solution.StrStr_Ver1(haystack, needle);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void StrStr_Ver2Test(string haystack, string needle, int expected)
    {
        var solution = new Solution0028();

        var actual = solution.StrStr_Ver2(haystack, needle);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "sadbutsad", "sad", 0
        },
        new object[]
        {
            "leetcode", "leeto", -1
        },
        new object[]
        {
            "hello", "ll", 2
        },
        new object[]
        {
            "aaaaa", "bba", -1
        },
        new object[]
        {
            "abc", "abcdefghijklkmn", -1
        }
    };
}