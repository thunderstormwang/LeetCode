using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
public class Solution0096Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NumTrees(int n, int expected)
    {
        var solution = new Solution0096();
        var actual = solution.NumTrees(n);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            1,
            1
        },
        new object[]
        {
            2,
            2
        },
        new object[]
        {
            3,
            5
        },
        new object[]
        {
            4,
            14
        },
        new object[]
        {
            5,
            42
        }
    };
}