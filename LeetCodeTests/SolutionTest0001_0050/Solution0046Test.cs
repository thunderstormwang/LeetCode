using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
public class Solution0046Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Permute_IterativeTest(int[] input, int[][] expectedArray)
    {
        var solution = new Solution0046();
        var actual = solution.Permute_Iterative(input);

        actual.Should().BeEquivalentTo(expectedArray);
    }
        
    [TestCaseSource(nameof(TestCases))]
    public void Permute_RecursiveTest(int[] input, int[][] expectedArray)
    {
        var solution046 = new Solution0046();
        var actual = solution046.Permute_Recursive(input);

        actual.Should().BeEquivalentTo(expectedArray);
    }
        
    [TestCaseSource(nameof(TestCases))]
    public void Permute_RecursiveSwapTest(int[] input, int[][] expectedArray)
    {
        var solution046 = new Solution0046();
        var actual = solution046.Permute_RecursiveSwap(input);

        actual.Should().BeEquivalentTo(expectedArray);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 0 },
            new int[][]
            {
                new int[] { 0 }
            }
        },
        new object[]
        {
            new int[] { 0, 1 },
            new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 }
            }
        },
        new object[]
        {
            new int[] { 0, 1, 2 },
            new int[][]
            {
                new int[] { 2, 0, 1 }, 
                new int[] { 0, 2, 1 }, 
                new int[] { 0, 1, 2 },
                new int[] { 2, 1, 0 }, 
                new int[] { 1, 2, 0 }, 
                new int[] { 1, 0, 2 }
            }
        }
    };
}