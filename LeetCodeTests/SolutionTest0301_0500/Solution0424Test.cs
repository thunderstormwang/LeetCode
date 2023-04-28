using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0424Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CharacterReplacementTest(string s, int k, int expected)
    {
        var solution = new Solution0424();
        var actual = solution.CharacterReplacement(s, k);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "ABAB",
            2,
            4
        },
        new object[]
        {
            "AABABBA",
            1,
            4
        }
    };
}