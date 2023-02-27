using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
public class Solution1035Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MaxUncrossedLines_Ver1Test(int[] nums1, int[] nums2, int expected)
    {
        var solution = new Solution1035();
        var actual = solution.MaxUncrossedLines_Ver1(nums1, nums2);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MaxUncrossedLines_Ver2Test(int[] nums1, int[] nums2, int expected)
    {
        var solution = new Solution1035();
        var actual = solution.MaxUncrossedLines_Ver2(nums1, nums2);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 4, 2 },
            new int[] { 1, 2, 4 },
            2
        },
        new object[]
        {
            new int[] { 2, 5, 1, 2, 5 },
            new int[] { 10, 5, 2, 1, 5, 2 },
            3
        },
        new object[]
        {
            new int[] { 1, 3, 7, 1, 7, 5 },
            new int[] { 1, 9, 2, 5, 1 },
            2
        }
    };
}