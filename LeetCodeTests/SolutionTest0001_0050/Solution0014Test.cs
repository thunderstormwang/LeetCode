using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0014Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LongestCommonPrefixTest(string[] strs, string expected)
    {
        var solution = new Solution0014();

        var actual = solution.LongestCommonPrefix(strs);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new string[] { "flower", "flow", "flight" },
            "fl"
        },
        new object[]
        {
            new string[] { "flower", "flower", "flower" },
            "flower"
        },
        new object[]
        {
            new string[] { "dog", "racecar", "car" },
            string.Empty
        },
        new object[]
        {
            new string[] { "dog" },
            "dog"
        },
        new object[]
        {
            new string[] { "dog", string.Empty, "car" },
            string.Empty
        }
    };
}