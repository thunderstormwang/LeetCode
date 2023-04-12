using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0377Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CombinationSum4Test(int[] nums, int target, int expected)
    {
        var solution = new Solution0377();
        var actual = solution.CombinationSum4(nums, target);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3 },
            4,
            7
        },
        new object[]
        {
            new int[] { 9 },
            3,
            0
        }
    };
}