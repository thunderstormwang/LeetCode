using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0654Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ConstructMaximumBinaryTree(int[] nums, int?[] expectedArray)
    {
        var expected = Utility.BuildTree(expectedArray, 0);

        var solution = new Solution0654();

        var actual = solution.ConstructMaximumBinaryTree(nums);

        Utility.CheckBinaryTree(actual, expected).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 3, 2, 1, 6, 0, 5 },
            new int?[] { 6, 3, 5, null, 2, 0, null, null, null, null, 1 }
        },
        new object[]
        {
            new int[] { 3, 2, 1 },
            new int?[] { 3, null, 2, null, null, null, 1 }
        }
    };
}