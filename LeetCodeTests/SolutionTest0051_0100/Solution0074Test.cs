using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0074Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SearchMatrix_Ver1Test(int[][] matrix, int target, bool expected)
    {
        var solution = new Solution0074();
        var actual = solution.SearchMatrix_Ver1(matrix, target);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void SearchMatrix_Ver2Test(int[][] matrix, int target, bool expected)
    {
        var solution = new Solution0074();
        var actual = solution.SearchMatrix_Ver2(matrix, target);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 }
            },
            3,
            true
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 }
            },
            13,
            false
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 3 }
            },
            3,
            true
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1 },
                new int[] { 3 }
            },
            3,
            true
        }
    };
}

// [[1, 3]]
// 3
// true
//
//
// [[1], [3]]
// 3
// true
//
// 要注意邊界!! While 終止條件
//
// edge case: 兩個元素的時候