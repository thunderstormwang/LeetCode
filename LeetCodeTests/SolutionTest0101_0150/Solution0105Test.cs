using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0105Test
{
    [TestCaseSource(nameof(TestCases))]
    public void BuildTreeTest(int[] preorder, int[] inorder, int?[] expectedArray)
    {
        var expected = Utility.BuildTree(expectedArray, 0);

        var solution = new Solution0105();
        var actual = solution.BuildTree(preorder, inorder);

        Utility.CheckBinaryTree(actual, expected).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 3, 9, 20, 15, 7 },
            new int[] { 9, 3, 15, 20, 7 },
            new int?[] { 3, 9, 20, null, null, 15, 7 }
        },
        new object[]
        {
            new int[] { -1 },
            new int[] { -1 },
            new int?[] { -1 }
        },
        new object[]
        {
            new int[] { 1, 2, 4, 5, 3, 6, 7 },
            new int[] { 4, 2, 5, 1, 6, 3, 7 },
            new int?[] { 1, 2, 3, 4, 5, 6, 7 }
        },
        new object[]
        {
            new int[] { 1, 2, 3 },
            new int[] { 2, 1, 3 },
            new int?[] { 1, 2, 3 }
        },
        new object[]
        {
            new int[] { 1, 2, 3 },
            new int[] { 3, 2, 1 },
            new int?[] { 1, 2, null, 3 }
        },
        new object[]
        {
            new int[] { 1, 2, 3 },
            new int[] { 1, 2, 3 },
            new int?[] { 1, null, 2, null, null, null, 3 }
        }
    };
}