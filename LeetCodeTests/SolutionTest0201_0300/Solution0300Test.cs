using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0300Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LengthOfLISTest(int[] nums, int expected)
    {
        var solution = new Solution0300();
        var actual = solution.LengthOfLIS(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 10, 9, 2, 5, 3, 7, 101, 18 },
            4
        },
        new object[]
        {
            new int[] { 0, 1, 0, 3, 2, 3 },
            4
        },
        new object[]
        {
            new int[] { 7, 7, 7, 7, 7, 7, 7 },
            1
        },
        new object[]
        {
            new int[] { 0 },
            1
        }
    };
}