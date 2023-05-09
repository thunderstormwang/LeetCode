using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0033Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SearchTest(int[] nums, int target, int expected)
    {
        var solution = new Solution0033();
        var actual = solution.Search(nums, target);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 4, 5, 6, 7, 0, 1, 2 },
            0,
            4
        },
        new object[]
        {
            new int[] { 4, 5, 6, 7, 0, 1, 2 },
            3,
            -1
        },
        new object[]
        {
            new int[] { 1 },
            0,
            -1
        },
        new object[]
        {
            new int[] { 1 },
            1,
            0
        },
        new object[]
        {
            new int[] { 1, 3 },
            2,
            -1
        }
    };
}