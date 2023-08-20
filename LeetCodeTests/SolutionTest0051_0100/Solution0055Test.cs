using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0055Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CanJump_Ver1Test(int[] nums, bool expected)
    {
        var solution = new Solution0055();
        
        var actual = solution.CanJump_Ver1(nums);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CanJump_Ver2Test(int[] nums, bool expected)
    {
        var solution = new Solution0055();
        
        var actual = solution.CanJump_Ver2(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 2, 3, 1, 1, 4 },
            true
        },
        new object[]
        {
            new int[] { 3, 2, 1, 0, 4 },
            false
        },
        new object[]
        {
            new int[] { 0, 0, 4 },
            false
        },
        new object[]
        {
            new int[] { 0 },
            true
        }
    };
}