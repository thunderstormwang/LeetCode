using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500;

[TestFixture]
public class Solution0283Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MoveZeroesTest(int[] nums, int[] expected)
    {
        var solution = new Solution0283();
        solution.MoveZeroes(nums);

        nums.Should().Equal(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 0, 1, 0, 3, 12 },
            new int[] { 1, 3, 12, 0, 0 }
        },
        new object[]
        {
            new int[] { 0 },
            new int[] { 0 }
        }
    };
}