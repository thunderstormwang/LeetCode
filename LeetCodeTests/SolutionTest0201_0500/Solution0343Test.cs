using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500;

[TestFixture]
public class Solution0343Test
{
    [TestCaseSource(nameof(TestCases))]
    public void IntegerBreakTest(int n, int expected)
    {
        var solution = new Solution0343();
        var actual = solution.IntegerBreak(n);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            2,
            1
        },
        new object[]
        {
            10,
            36
        },
        new object[]
        {
            8,
            18
        }
    };
}