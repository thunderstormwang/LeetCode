﻿using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0100Test
{
    [TestCaseSource(nameof(TestCases))]
    public void IsSameTree_Ver1Test(int?[] array1, int?[] array2, bool expected)
    {
        var root1 = Utility.BuildTree(array1, 0);
        var root2 = Utility.BuildTree(array2, 0);

        var solution = new Solution0100();
        var actual = solution.IsSameTree_Ver1(root1, root2);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void IsSameTree_Ver2Test(int?[] array1, int?[] array2, bool expected)
    {
        var root1 = Utility.BuildTree(array1, 0);
        var root2 = Utility.BuildTree(array2, 0);

        var solution = new Solution0100();
        var actual = solution.IsSameTree_Ver2(root1, root2);

        actual.Should().Be(expected);
    }
        
    [TestCaseSource(nameof(TestCases))]
    public void IsSameTree_Ver3Test(int?[] array1, int?[] array2, bool expected)
    {
        var root1 = Utility.BuildTree(array1, 0);
        var root2 = Utility.BuildTree(array2, 0);

        var solution = new Solution0100();
        var actual = solution.IsSameTree_Ver3(root1, root2);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 1, 2, 3 },
            new int?[] { 1, 2, 3 },
            true
        },
        new object[]
        {
            new int?[] { 1, 2 },
            new int?[] { 1, null, 2 },
            false
        },
        new object[]
        {
            new int?[] { 1, 2, 1 },
            new int?[] { 1, 1, 2 },
            false
        }
    };
}