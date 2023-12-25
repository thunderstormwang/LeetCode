using FluentAssertions;
using LeetCode.Solution0151_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0151_0200;

[TestFixture]
[Category("SolutionTest0151_0200")]
public class Solution0198Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Rob_Ver1Test(int[] nums, int expected)
    {
        var solution = new Solution0198();

        var actual = solution.Rob_Ver1(nums);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void Rob_Ver2Test(int[] nums, int expected)
    {
        var solution = new Solution0198();

        var actual = solution.Rob_Ver2(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 1 },
            4
        },
        new object[]
        {
            new int[] { 2, 7, 9, 3, 1 },
            12
        },
        new object[]
        {
            new int[] { 2, 1, 1, 2 },
            4
        }
    };
}