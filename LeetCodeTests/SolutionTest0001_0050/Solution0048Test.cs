using System.Numerics;
using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0048Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Rotate_Ver1Test(int[][] matrix, int[][] expected)
    {
        var copyMatrix = new int [matrix.Length][];
        for(var i = 0; i < matrix.Length; i++)
        {
            copyMatrix[i] = new int[matrix[i].Length];
            for (var j = 0; j < matrix[i].Length; j++)
            {
                copyMatrix[i][j] = matrix[i][j];
            }
        }
        var solution = new Solution0048();
        
        solution.Rotate_Ver1(copyMatrix);

        for (var i = 0; i < copyMatrix.Length; i++)
        {
            copyMatrix[i].Should().Equal(expected[i]);
        }
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void Rotate_Ver2Test(int[][] matrix, int[][] expected)
    {
        var copyMatrix = new int [matrix.Length][];
        for(var i = 0; i < matrix.Length; i++)
        {
            copyMatrix[i] = new int[matrix[i].Length];
            for (var j = 0; j < matrix[i].Length; j++)
            {
                copyMatrix[i][j] = matrix[i][j];
            }
        }
        var solution = new Solution0048();
        
        solution.Rotate_Ver2(copyMatrix);

        for (var i = 0; i < copyMatrix.Length; i++)
        {
            copyMatrix[i].Should().Equal(expected[i]);
        }
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 1 }
            },
            new int[][]
            {
                new int[] { 1 }
            }
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 2 }, 
                new int[] { 3, 4 }
            },
            new int[][]
            {
                new int[] { 3, 1 }, 
                new int[] { 4, 2 }
            },
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 2, 3 }, 
                new int[] { 4, 5, 6 }, 
                new int[] { 7, 8, 9 }
            },
            new int[][] 
            { 
                new int[] { 7, 4, 1 }, 
                new int[] { 8, 5, 2 }, 
                new int[] { 9, 6, 3 } 
            },
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 5, 1, 9, 11 }, 
                new int[] { 2, 4, 8, 10 }, 
                new int[] { 13, 3, 6, 7 },
                new int[] { 15, 14, 12, 16 }
            },
            new int[][]
            {
                new int[] { 15, 13, 2, 5 }, 
                new int[] { 14, 3, 4, 1 }, 
                new int[] { 12, 6, 8, 9 },
                new int[] { 16, 7, 10, 11 }
            },
        }
    };
}