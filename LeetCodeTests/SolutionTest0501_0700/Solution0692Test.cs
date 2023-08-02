using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0692Test
{
    [TestCaseSource(nameof(TestCases))]
    public void TopKFrequentTest(string[] words, int k, IList<string> expected)
    {
        var solution = new Solution0692();

        var actual = solution.TopKFrequent(words, k);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new string[] { "i", "love", "leetcode", "i", "love", "coding" },
            2,
            new List<string>() { "i", "love" }
        },
        new object[]
        {
            new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" },
            4,
            new List<string>() { "the", "is", "sunny", "day" }
        }
    };
}