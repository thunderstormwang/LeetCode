using FluentAssertions;
using LeetCode.Models;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0285Test
{
    [TestCaseSource(nameof(TestCases))]
    public void InorderSuccessor_Ver1Test(int?[] inputArray, TreeNode p, TreeNode expected)
    {
        var root = Utility.BuildTree(inputArray, 0);

        var solution = new Solution0285();
        var actual = solution.InorderSuccessor_Ver1(root, p);

        if (expected == null)
        {
            actual.Should().BeNull();
        }
        else
        {
            actual.val.Should().Be(expected.val);
        }
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void InorderSuccessor_Ver2Test(int?[] inputArray, TreeNode p, TreeNode expected)
    {
        var root = Utility.BuildTree(inputArray, 0);

        var solution = new Solution0285();
        var actual = solution.InorderSuccessor_Ver2(root, p);

        if (expected == null)
        {
            actual.Should().BeNull();
        }
        else
        {
            actual.val.Should().Be(expected.val);
        }
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 2, 1, 3 },
            new TreeNode(1),
            new TreeNode(2)
        },
        new object[]
        {
            new int?[] { 5, 3, 6, 2, 4, null, null, 1 },
            new TreeNode(6),
            null
        },
        new object[]
        {
            new int?[] { 5, 3, 6, 2, 4, null, 7, 1 },
            new TreeNode(6),
            new TreeNode(7)
        }
    };
}