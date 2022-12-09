using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500;

[TestFixture]
public class Solution0376Test
{
    [TestCaseSource(nameof(TestCases))]
    public void WiggleMaxLength(int[] nums, int expected)
    {
        var solution = new Solution0376();
        var actual = solution.WiggleMaxLength(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 7, 4, 9, 2, 5 },
            6
        },
        new object[]
        {
            new int[] { 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 },
            7
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            2
        },
        new object[]
        {
            new int[] { 1, 2 },
            2
        },
        new object[]
        {
            new int[] { 0, 0 },
            1
        },
        new object[]
        {
            new int[] { 0, 0, 0 },
            1
        }
    };
}