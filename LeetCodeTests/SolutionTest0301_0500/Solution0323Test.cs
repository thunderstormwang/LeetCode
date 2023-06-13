using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0323Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CombinationSum4_Ver1Test(int n, int[][] edges, int expected)
    {
        var solution = new Solution0323();
        var actual = solution.CountComponents_Ver1(n, edges);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CombinationSum4_Ver2Test(int n, int[][] edges, int expected)
    {
        var solution = new Solution0323();
        var actual = solution.CountComponents_Ver2(n, edges);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CombinationSum4_Ver3Test(int n, int[][] edges, int expected)
    {
        var solution = new Solution0323();
        var actual = solution.CountComponents_Ver3(n, edges);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            5,
            new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            },
            2
        },
        new object[]
        {
            5,
            new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 }
            },
            1
        }
    };
}