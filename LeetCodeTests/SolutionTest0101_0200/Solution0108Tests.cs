using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
[Category("SolutionTest0101_0200")]
public class Solution0108Tests
{
    [TestCaseSource(nameof(TestCases))]
    public void SortedArrayToBST_Ver1Test(int[] nums, int?[] expectedArray)
    {
        var expected = Utility.BuildTree(expectedArray, 0);

        var solution = new Solution0108();
        var actual = solution.SortedArrayToBST_Ver1(nums);

        Utility.CheckBinaryTree(actual, expected).Should().BeTrue();
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void SortedArrayToBST_Ver2Test(int[] nums, int?[] expectedArray)
    {
        var expected = Utility.BuildTree(expectedArray, 0);

        var solution = new Solution0108();
        var actual = solution.SortedArrayToBST_Ver2(nums);

        Utility.CheckBinaryTree(actual, expected).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { -10, -3, 0, 5, 9 },
            new int?[] { 0, -10, 5, null, -3, null, 9 }
        },
        new object[]
        {
            new int[] { 1, 3 },
            new int?[] { 1, null, 3 }
        }
    };
}