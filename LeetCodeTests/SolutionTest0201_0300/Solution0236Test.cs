using FluentAssertions;
using LeetCode.Models;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0236Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LowestCommonAncestor_Ver1Test(int?[] inputArray, int p, int q, TreeNode expected)
    {
        var root = Utility.BuildTree(inputArray, 0);
        var nodeP = new TreeNode(p);
        var nodeQ = new TreeNode(q);

        var solution = new Solution0236();
        var actual = solution.LowestCommonAncestor_Ver1(root, nodeP, nodeQ);

        actual.val.Should().Be(expected.val);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void LowestCommonAncestor_Ver2Test(int?[] inputArray, int p, int q, TreeNode expected)
    {
        var root = Utility.BuildTree(inputArray, 0);
        var nodeP = new TreeNode(p);
        var nodeQ = new TreeNode(q);

        var solution = new Solution0236();
        var actual = solution.LowestCommonAncestor_Ver2(root, nodeP, nodeQ);

        actual.val.Should().Be(expected.val);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 },
            5,
            1,
            new TreeNode(3)
        },
        new object[]
        {
            new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 },
            5,
            4,
            new TreeNode(5)
        },
        new object[]
        {
            new int?[] { 1, 2 },
            1,
            2,
            new TreeNode(1)
        }
    };
}