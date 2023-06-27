using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0738Test
{
    [TestCaseSource(nameof(TestCases))]
    public void PartitionLabelsTest(int n, int expected)
    {
        var solution = new Solution0738();
        var actual = solution.MonotoneIncreasingDigits(n);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            10,
            9
        },
        new object[]
        {
            1234,
            1234
        },
        new object[]
        {
            332,
            299
        },
        new object[]
        {
            100,
            99
        }
    };
}