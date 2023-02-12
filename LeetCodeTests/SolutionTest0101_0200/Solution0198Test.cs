using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
public class Solution0198Test
{
    [TestCaseSource(nameof(TestCases))]
    public void RobTest(int[] nums, int expected)
    {
        var solution = new Solution0198();
        var actual = solution.Rob(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 1 },
            4
        },
        new object[]
        {
            new int[] { 2, 7, 9, 3, 1 },
            12
        }
    };
}