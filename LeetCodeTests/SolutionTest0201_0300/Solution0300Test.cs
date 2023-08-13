using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0300Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LengthOfLIS_Ver1Test(int[] nums, int expected)
    {
        var solution = new Solution0300();

        var actual = solution.LengthOfLIS_Ver1(nums);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void LengthOfLIS_Ver2Test(int[] nums, int expected)
    {
        var solution = new Solution0300();

        var actual = solution.LengthOfLIS_Ver2(nums);

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
        },
        new object[]
        {
            new int[] { 1, 3, 6, 7, 9, 4, 10, 5, 6 },
            6
        }
    };
}