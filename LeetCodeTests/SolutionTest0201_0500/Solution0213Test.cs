using FluentAssertions;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500;

[TestFixture]
public class Solution0213Test
{
    [TestCaseSource(nameof(TestCases))]
    public void RobTest(int[] nums, int expected)
    {
        var solution = new Solution0213();
        var actual = solution.Rob(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 2, 3, 2 },
            3
        },
        new object[]
        {
            new int[] { 1, 2, 3, 1 },
            4
        },
        new object[]
        {
            new int[] { 1, 2, 3 },
            3
        }
    };
}