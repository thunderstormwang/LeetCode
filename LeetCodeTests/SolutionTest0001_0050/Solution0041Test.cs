using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0041Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FirstMissingPositiveTest(int[] nums, int expected)
    {
        var solution = new Solution0041();
        var actual = solution.FirstMissingPositive(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 0 },
            3
        },
        new object[]
        {
            new int[] { 3, 4, -1, 1 },
            2
        },
        new object[]
        {
            new int[] { 7, 8, 9, 11, 12 },
            1
        },
        new object[]
        {
            new int[] { 1, 1 },
            2
        }
    };
}