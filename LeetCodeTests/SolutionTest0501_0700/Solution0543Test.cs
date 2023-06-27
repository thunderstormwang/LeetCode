using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0543Test
{
    [TestCaseSource(nameof(TestCases))]
    public void DiameterOfBinaryTreeTest(int?[] array, int expected)
    {
        var root = Utility.BuildTree(array, 0);
        
        var solution = new Solution0543();
        var actual = solution.DiameterOfBinaryTree(root);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 1, 2, 3, 4, 5 },
            3
        },
        new object[]
        {
            new int?[] { 1, 2 },
            1
        },
    };
}