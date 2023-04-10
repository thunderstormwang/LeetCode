using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
public class Solution0496Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NextGreaterElementTest(int[] nums1, int[] nums2, int[] expected)
    {
        var solution = new Solution0496();
        var actual = solution.NextGreaterElement(nums1, nums2);

        actual.Should().Equal(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 4, 1, 2 },
            new int[] { 1, 3, 4, 2 },
            new int[] { -1, 3, -1 },
        },
        new object[]
        {
            new int[] { 2, 4 },
            new int[] { 1, 2, 3, 4 },
            new int[] { 3, -1 },
        },
        new object[]
        {
            new int[] { 1, 3, 5, 2, 4 },
            new int[] { 6, 5, 4, 3, 2, 1, 7 },
            new int[] { 7, 7, 7, 7, 7 },
        }
    };
}