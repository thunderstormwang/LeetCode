using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution0718Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindLength_MyFirstAnswerTest(int[] nums1, int[] nums2, int expected)
    {
        var solution = new Solution0718();
        var actual = solution.FindLength_MyFirstAnswer(nums1, nums2);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void FindLength_Ver1Test(int[] nums1, int[] nums2, int expected)
    {
        var solution = new Solution0718();
        var actual = solution.FindLength_Ver1(nums1, nums2);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void FindLength_Ver2Test(int[] nums1, int[] nums2, int expected)
    {
        var solution = new Solution0718();
        var actual = solution.FindLength_Ver2(nums1, nums2);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 2, 1 },
            new int[] { 3, 2, 1, 4, 7 },
            3
        },
        new object[]
        {
            new int[] { 0, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0 },
            5
        },
        new object[]
        {
            new int[] { 1, 0, 0, 0, 1 },
            new int[] { 1, 0, 0, 1, 1 },
            3
        },
        new object[]
        {
            new int[] { 0, 0, 0, 0, 1 },
            new int[] { 1, 0, 0, 0, 0 },
            4
        },
        new object[]
        {
            new int[] { 1, 2, 3, 2, 8 },
            new int[] { 5, 6, 1, 4, 7 },
            1
        }
    };
}