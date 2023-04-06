using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500;

[TestFixture]
public class Solution0238Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ProductExceptSelfTest(int[] nums, int[] expected)
    {
        var solution = new Solution0238();
        var actual = solution.ProductExceptSelf(nums);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 10, 9, 2, 5, 3, 7, 101, 18 },
            4
        },
        new object[]
        {
            new int[] { 0, 1, 0, 3, 2, 3 },
            4
        },
        new object[]
        {
            new int[] { 7, 7, 7, 7, 7, 7, 7 },
            1
        },
        new object[]
        {
            new int[] { 0 },
            1
        }
    };
}