using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0968Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MinCameraCover(int? [] array, int expected)
    {
        var tree = Utility.BuildTree(array, 0);
        var solution = new Solution0968();

        var actual = solution.MinCameraCover(tree);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 0, 0, null, 0, 0 },
            1
        },
        new object[]
        {
            new int?[] { 0, 0, null, 0, null, 0, null, null, 0 },
            2
        }
    };
}