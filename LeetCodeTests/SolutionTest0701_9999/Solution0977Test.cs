using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0977Test
{
    [TestCase(new int[] { -4, -1, 0, 3, 10 }, new int[] { 0, 1, 9, 16, 100 })]
    [TestCase(new int[] { -7, -3, 2, 3, 11 }, new int[] { 4, 9, 9, 49, 121 })]
    [TestCase(new int[] { 1, 2, 2, 3 }, new int[] { 1, 4, 4, 9 })]
    [TestCase(new int[] { -3, -2, -2, -1 }, new int[] { 1, 4, 4, 9 })]
    public void SortedSquares(int[] nums, int[] expected)
    {
        var solution = new Solution0977();
        var actual = solution.SortedSquares(nums);

        actual.Should().Equal(expected);
    }
}