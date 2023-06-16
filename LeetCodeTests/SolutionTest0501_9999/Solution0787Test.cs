using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution0787Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindCheapestPrice_Ver1Test(int n, int[][] flights, int src, int dst, int k, int expected)
    {
        var solution = new Solution0787();
        var actual = solution.FindCheapestPrice_Ver1(n, flights, src, dst, k);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void FindCheapestPrice_Ver2Test(int n, int[][] flights, int src, int dst, int k, int expected)
    {
        var solution = new Solution0787();
        var actual = solution.FindCheapestPrice_Ver2(n, flights, src, dst, k);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void FindCheapestPrice_Ver3Test(int n, int[][] flights, int src, int dst, int k, int expected)
    {
        var solution = new Solution0787();
        var actual = solution.FindCheapestPrice_Ver3(n, flights, src, dst, k);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            4,
            new int[][]
            {
                new int[] { 0, 1, 100 },
                new int[] { 1, 2, 100 },
                new int[] { 2, 0, 100 },
                new int[] { 1, 3, 600 },
                new int[] { 2, 3, 200 },
            },
            0,
            3,
            1,
            700
        },
        new object[]
        {
            3,
            new int[][]
            {
                new int[] { 0, 1, 100 },
                new int[] { 1, 2, 100 },
                new int[] { 0, 2, 500 }
            },
            0,
            2,
            1,
            200
        },
        new object[]
        {
            3,
            new int[][]
            {
                new int[] { 0, 1, 100 },
                new int[] { 1, 2, 100 },
                new int[] { 0, 2, 500 }
            },
            0,
            2,
            0,
            500
        }
    };
}