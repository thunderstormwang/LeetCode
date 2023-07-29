using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0215Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindKthLargest_Ver1Test(int[] nums, int k, int expected)
    {
        var solution = new Solution0215();
        var actual = solution.FindKthLargest_Ver1(nums, k);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void FindKthLargest_Ver2Test(int[] nums, int k, int expected)
    {
        var solution = new Solution0215();
        var actual = solution.FindKthLargest_Ver2(nums, k);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 3, 2, 1, 5, 6, 4 },
            2,
            5
        },
        new object[]
        {
            new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 },
            4,
            4
        },

        new object[]
        {
            new int[] { 1 },
            1,
            1
        },
        new object[]
        {
            new int[] { 2, 1 },
            1,
            2
        },
        new object[]
        {
            new int[] { 99, 99 },
            1,
            99
        }
    };
}