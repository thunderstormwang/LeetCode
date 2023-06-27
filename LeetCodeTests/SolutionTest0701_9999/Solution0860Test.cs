using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0860Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LemonadeChangeTest(int [] bills, bool expected)
    {
        var solution = new Solution0860();
        var actual = solution.LemonadeChange(bills);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 5, 5, 5, 10, 20 },
            true
        },
        new object[]
        {
            new int[] { 5, 5, 10, 10, 20 },
            false
        }
    };
}