using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution0763Test
{
    [TestCaseSource(nameof(TestCases))]
    public void PartitionLabelsTest(string s , int[] expected)
    {
        var solution = new Solution0763();
        var actual = solution.PartitionLabels(s);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "ababcbacadefegdehijhklij",
            new int[] { 9, 7, 8 }
        },
        new object[]
        {
            "eccbbbbdec",
            new int[] { 10 }
        }
    };
}