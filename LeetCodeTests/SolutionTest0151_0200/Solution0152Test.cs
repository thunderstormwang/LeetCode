using FluentAssertions;
using LeetCode.Solution0151_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0151_0200;

[TestFixture]
[Category("SolutionTest0151_0200")]
public class Solution0152Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindMin_Ver1Test(int[] nums, int expected)
    {
        var solution = new Solution0152();

        var actual = solution.MaxProduct_Ver1(nums);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void FindMin_Ver2Test(int[] nums, int expected)
    {
        var solution = new Solution0152();

        var actual = solution.MaxProduct_Ver2(nums);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void FindMin_Ver3Test(int[] nums, int expected)
    {
        var solution = new Solution0152();

        var actual = solution.MaxProduct_Ver3(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 2, 3, -2, 4 },
            6,
        },
        new object[]
        {
            new int[] { -2, 0, -1 },
            0,
        },
        new object[]
        {
            new int[] { -2 },
            -2,
        },
        new object[]
        {
            new int[] { 2, -1, 1, 1 },
            2,
        },
        new object[]
        {
            new int[] { -4, -3, -2 },
            12,
        }
    };
}