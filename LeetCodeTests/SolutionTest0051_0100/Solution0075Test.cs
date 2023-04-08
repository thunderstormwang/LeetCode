using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
public class Solution0075Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MinDistance_Ver1Test(int[] nums, int[] expected)
    {
        var solution = new Solution0075();

        solution.SortColors(nums);

        nums.Should().Equal(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 2, 0, 2, 1, 1, 0 },
            new int[] { 0, 0, 1, 1, 2, 2 }
        },
        new object[]
        {
            new int[] { 2, 0, 1 },
            new int[] { 0, 1, 2 }
        },
        new object[]
        {
            new int[] { 1, 2, 0 },
            new int[] { 0, 1, 2 }
        }
    };
}