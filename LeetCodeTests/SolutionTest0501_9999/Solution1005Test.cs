using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution1005Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LargestSumAfterKNegations(int[] nums, int k, int expected)
    {
        var array = new int [nums.Length];
        Array.Copy(nums, array, nums.Length);
        
        var solution = new Solution1005();
        var actual = solution.LargestSumAfterKNegations(array, k);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void LargestSumAfterKNegations_SortByAbs(int[] nums, int k, int expected)
    {
        var array = new int [nums.Length];
        Array.Copy(nums, array, nums.Length);
        
        var solution = new Solution1005();
        var actual = solution.LargestSumAfterKNegations_SortByAbs(nums, k);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[]
            {
                4, 2, 3
            },
            1,
            5
        },
        new object[]
        {
            new int[]
            {
                3, -1, 0, 2
            },
            3,
            6
        },
        new object[]
        {
            new int[]
            {
                2, -3, -1, 5, -4
            },
            2,
            13
        }
    };
}