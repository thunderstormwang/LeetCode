using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0104Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MaxDepth_Ver1Test(int?[] array, int expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0104();
        var actual = solution.MaxDepth_Ver1(root);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void MaxDepth_Ver2Test(int?[] array, int expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0104();
        var actual = solution.MaxDepth_Ver2(root);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 3, 9, 20, null, null, 15, 7 },
            3
        },
        new object[]
        {
            new int?[] { 1, null, 2 },
            2
        },
        new object[]
        {
            new int?[] { },
            0
        },
    };
}