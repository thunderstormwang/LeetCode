using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution0733Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FloodFill_BFSTest(int[][] image, int sr, int sc, int color, int[][] expected)
    {
        var array = new int [image.Length][];
        for (var i = 0; i < image.Length; i++)
        {
            array[i] = new int[image[i].Length];
            Array.Copy(image[i], array[i], image[i].Length);
        }

        var solution = new Solution0733();
        var actual = solution.FloodFill_BFS(array, sr, sc, color);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void FloodFill_DFSTest(int[][] image, int sr, int sc, int color, int[][] expected)
    {
        var array = new int [image.Length][];
        for (var i = 0; i < image.Length; i++)
        {
            array[i] = new int[image[i].Length];
            Array.Copy(image[i], array[i], image[i].Length);
        }

        var solution = new Solution0733();
        var actual = solution.FloodFill_DFS(array, sr, sc, color);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 }
            },
            1,
            1,
            2,
            new int[][]
            {
                new int[] { 2, 2, 2 },
                new int[] { 2, 2, 0 },
                new int[] { 2, 0, 1 }
            }
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }
            },
            0,
            0,
            0,
            new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }
            }
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 2, 2, 2 },
                new int[] { 2, 0, 2 },
                new int[] { 2, 2, 2 }
            },
            1,
            1,
            0,
            new int[][]
            {
                new int[] { 2, 2, 2 },
                new int[] { 2, 0, 2 },
                new int[] { 2, 2, 2 }
            }
        }
    };
}