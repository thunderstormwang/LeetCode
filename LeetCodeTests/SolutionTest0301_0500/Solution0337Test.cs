using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0337Test
{
    [TestCaseSource(nameof(TestCases))]
    public void RobTest(int?[] nums, int expected)
    {
        var root = Utility.BuildTree(nums, 0);

        var solution = new Solution0337();
        var actual = solution.Rob(root);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 3, 2, 3, null, 3, null, 1 },
            7
        },
        new object[]
        {
            new int?[] { 3, 4, 5, 1, 3, null, 1 },
            9
        },
        new object[]
        {
            new int?[] { 4, 1, null, 2, null, null, null, 3 },
            7
        },
        new object[]
        {
            new int?[] { 2, 1, 3, null, 4 },
            7
        }
    };
}