using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
public class Solution0322Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CombinationSum4_Ver1Test(int[] nums, int target, int expected)
    {
        var solution = new Solution0322();
        var actual = solution.CoinChange_Ver1(nums, target);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CombinationSum4_Ver2Test(int[] nums, int target, int expected)
    {
        var solution = new Solution0322();
        var actual = solution.CoinChange_Ver2(nums, target);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 5 },
            11,
            3
        },
        new object[]
        {
            new int[] { 2 },
            3,
            -1
        },
        new object[]
        {
            new int[] { 1 },
            0,
            0
        }
    };
}