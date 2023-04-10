using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
public class Solution0416Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CanPartition_Ver1Test(int[] nums, bool expected)
    {
        var solution = new Solution0416();
        var actual = solution.CanPartition_Ver1(nums);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CanPartition_Ver2Test(int[] nums, bool expected)
    {
        var solution = new Solution0416();
        var actual = solution.CanPartition_Ver2(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 5, 11, 5 },
            true
        },
        new object[]
        {
            new int[] { 1, 2, 3, 5 },
            false
        }
    };
}