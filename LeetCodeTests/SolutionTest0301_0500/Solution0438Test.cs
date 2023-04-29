using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0438Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindAnagramsTest(string s, string p, IList<int> expected)
    {
        var solution = new Solution0438();
        var actual = solution.FindAnagrams(s, p);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "cbaebabacd",
            "abc",
            new int[] { 0, 6 }
        },
        new object[]
        {
            "abab",
            "ab",
            new int[] { 0, 1, 2 }
        }
    };
}