using FluentAssertions;
using LeetCode.Models;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0863Test
{
    [TestCaseSource(nameof(TestCases))]
    public void DistanceKTest(int?[] array, int target, int k, IList<int> expected)
    {
        var root = Utility.BuildTree(array, 0);
        var targetNode = FindTarget(root, target);

        var solution = new Solution0863();
        var actual = solution.DistanceK(root, targetNode, k);

        actual.Should().BeEquivalentTo(expected);
    }

    private TreeNode FindTarget(TreeNode root, int target)
    {
        if (root == null)
        {
            return null;
        }
        
        if (root.val == target)
        {
            return root;
        }
        
        var left = FindTarget(root.left, target);
        if (left != null)
        {
            return left;
        }
        
        var right = FindTarget(root.right, target);
        if (right != null)
        {
            return right;
        }

        return null;
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 },
            5,
            2,
            new int[] { 7, 4, 1 }
        },
        new object[]
        {
            new int?[] { 1 },
            1,
            3,
            new int[] { }
        }
    };
}