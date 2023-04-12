using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution2235Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SumTest(int num1, int num2, int expected)
    {
        var solution = new Solution2235();
        var actual = solution.Sum(num1, num2);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            12,
            5,
            17
        },
        new object[]
        {
            -10,
            4,
            -6
        }
    };
}