﻿using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0103Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ZigzagLevelOrder_Ver1Test(int?[] array, IList<IList<int>> expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0103();
        var actual = solution.ZigzagLevelOrder_Ver1(root);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void ZigzagLevelOrder_Ver2Test(int?[] array, IList<IList<int>> expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0103();
        var actual = solution.ZigzagLevelOrder_Ver2(root);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void ZigzagLevelOrder_Ver3Test(int?[] array, IList<IList<int>> expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0103();
        var actual = solution.ZigzagLevelOrder_Ver3(root);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void ZigzagLevelOrder_Ver4Test(int?[] array, IList<IList<int>> expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0103();
        var actual = solution.ZigzagLevelOrder_Ver4(root);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 3,9,20,null,null,15,7 },
            new int[][]
            {
                new int[] { 3 },
                new int[] { 20, 9 },
                new int[] { 15, 7 }
            }
        },
        new object[]
        {
            new int?[] { 1 },
            new int[][]
            {
                new int[] { 1 }
            }
        },
        new object[]
        {
            new int?[] { },
            new int[][] { }
        }
    };
}