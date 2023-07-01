using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0124Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MaxPathSum_Ver1Test(int?[] array, int expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0124();
        var actual = solution.MaxPathSum_Ver1(root);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MaxPathSum_Ver2Test(int?[] array, int expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0124();
        var actual = solution.MaxPathSum_Ver2(root);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 1, 2, 3 },
            6
        },
        new object[]
        {
            new int?[] { -10, 9, 20, null, null, 15, 7 },
            42
        },
        new object[]
        {
            new int?[] { -3 },
            -3
        },
        new object[]
        {
            new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, null, null, 1 },
            48
        }
    };
}