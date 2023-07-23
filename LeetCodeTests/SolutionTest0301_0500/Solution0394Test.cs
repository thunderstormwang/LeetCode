using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0394Test
{
    [TestCaseSource(nameof(TestCases))]
    public void DecodeStringTest(string s, string expected)
    {
        var solution = new Solution0394();
        var actual = solution.DecodeString(s);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "3[a]2[bc]",
            "aaabcbc"
        },
        new object[]
        {
            "3[a2[c]]",
            "accaccacc"
        },
        new object[]
        {
            "2[abc]3[cd]ef",
            "abcabccdcdcdef"
        }
    };
}