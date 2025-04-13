using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0031Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NextPermutation_Ver1Test(int[] nums, int[] expected)
    {
        var actual = new int [nums.Length];
        Array.Copy(nums, actual, nums.Length);

        var solution = new Solution0031();
        solution.NextPermutation_Ver1(actual);

        actual.Should().Equal(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void NextPermutation_Ver2Test(int[] nums, int[] expected)
    {
        var actual = new int [nums.Length];
        Array.Copy(nums, actual, nums.Length);

        var solution = new Solution0031();
        solution.NextPermutation_Ver2(actual);

        actual.Should().Equal(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3 },
            new int[] { 1, 3, 2 }
        },
        new object[]
        {
            new int[] { 1, 3, 2 },
            new int[] { 2, 1, 3 }
        },
        new object[]
        {
            new int[] { 2, 1, 3 },
            new int[] { 2, 3, 1 }
        },
        new object[]
        {
            new int[] { 2, 3, 1 },
            new int[] { 3, 1, 2 }
        },
        new object[]
        {
            new int[] { 3, 1, 2 },
            new int[] { 3, 2, 1 }
        },
        new object[]
        {
            new int[] { 3, 2, 1 },
            new int[] { 1, 2, 3 }
        },
        new object[]
        {
            new int[] { 8, 7, 5, 3, 6, 4, 2, 1 },
            new int[] { 8, 7, 5, 4, 1, 2, 3, 6 }
        }
    };
}