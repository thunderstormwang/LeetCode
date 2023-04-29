using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0271Test
{
    [TestCaseSource(nameof(TestCases))]
    public void EncodeAndDecodeStringsTest(List<string> strs, List<string> expected)
    {
        var solution = new Solution0271();
        var encoded = solution.Encode(strs);
        var actual = solution.Decode(encoded);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new List<string> { "lint", "code", "love", "you" },
            new List<string> { "lint", "code", "love", "you" }
        },
        new object[]
        {
            new List<string> { "we", "say", ":", "yes" },
            new List<string> { "we", "say", ":", "yes" }
        }
    };
}