using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0658Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindClosestElements_Ver1Tree(int[] arr, int k, int x, int[] expected)
    {
        var solution = new Solution0658();

        var actual = solution.FindClosestElements_Ver1(arr, k, x);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void FindClosestElements_Ver2Tree(int[] arr, int k, int x, int[] expected)
    {
        var solution = new Solution0658();

        var actual = solution.FindClosestElements_Ver2(arr, k, x);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            4,
            3,
            new int[] { 1, 2, 3, 4 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            4,
            -1,
            new int[] { 1, 2, 3, 4 }
        }
    };
}