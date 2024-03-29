﻿using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0226Test
{
    [TestCaseSource(nameof(TestCases))]
    public void InvertTree_DFS_RecursiveTest(int?[] inputArray, int?[] expectedArray)
    {
        var root = Utility.BuildTree(inputArray, 0);
        var expected = Utility.BuildTree(expectedArray, 0);

        var solution = new Solution0226();
        var actual = solution.InvertTree_Ver1(root);

        Utility.CheckBinaryTree(actual, expected).Should().BeTrue();
    }

    [TestCaseSource(nameof(TestCases))]
    public void InvertTree_DFS_IterativeTest(int?[] inputArray, int?[] expectedArray)
    {
        var root = Utility.BuildTree(inputArray, 0);
        var expected = Utility.BuildTree(expectedArray, 0);

        var solution = new Solution0226();
        var actual = solution.InvertTree_Ver2(root);

        Utility.CheckBinaryTree(actual, expected).Should().BeTrue();
    }

    [TestCaseSource(nameof(TestCases))]
    public void InvertTree_BFSTest(int?[] inputArray, int?[] expectedArray)
    {
        var root = Utility.BuildTree(inputArray, 0);
        var expected = Utility.BuildTree(expectedArray, 0);

        var solution = new Solution0226();
        var actual = solution.InvertTree_Ver3(root);

        Utility.CheckBinaryTree(actual, expected).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 4, 2, 7, 1, 3, 6, 9 },
            new int?[] { 4, 7, 2, 9, 6, 3, 1 }
        },
        new object[]
        {
            new int?[] { 2, 1, 3 },
            new int?[] { 2, 3, 1 }
        },
        new object[]
        {
            Array.Empty<int?>(),
            Array.Empty<int?>()
        }
    };
}