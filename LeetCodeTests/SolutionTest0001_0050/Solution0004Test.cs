using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0004Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindMedianSortedArraysTest(int[] nums1, int[] nums2, double expected)
    {
        var solution003 = new Solution0004();
        var actual = solution003.FindMedianSortedArrays(nums1, nums2);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 3 },
            new int[] { 2 },
            2d
        },
        new object[]
        {
            new int[] { 1, 2 },
            new int[] { 3, 4 },
            2.5d
        }
    };
}