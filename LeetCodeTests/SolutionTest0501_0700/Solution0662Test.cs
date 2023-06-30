using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0662Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ConstructMaximumBinaryTree_Ver1(int?[] array, int expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0662();
        var actual = solution.WidthOfBinaryTree_Ver1(root);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void ConstructMaximumBinaryTree_Ver2(int?[] array, int expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0662();
        var actual = solution.WidthOfBinaryTree_Ver2(root);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 1, 3, 2, 5, 3, null, 9 },
            4
        },
        new object[]
        {
            new int?[] { 1, 3, 2, 5, null, null, 9, 6, null, null, null, null, null, 7 },
            7
        },
        new object[]
        {
            new int?[] { 1, 3, 2, 5 },
            2
        }
    };
}