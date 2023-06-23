using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0098Test
{
    [TestCaseSource(nameof(TestCases))]
    public void IsValidBST_Ver1Test(int?[] inputArray, bool expected)
    {
        var root = Utility.BuildTree(inputArray, 0);

        var solution = new Solution0098();
        var actual = solution.IsValidBST_Ver1(root);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void IsValidBST_Ver2Test(int?[] inputArray, bool expected)
    {
        var root = Utility.BuildTree(inputArray, 0);

        var solution = new Solution0098();
        var actual = solution.IsValidBST_Ver2(root);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 2, 1, 3 },
            true
        },
        new object[]
        {
            new int?[] { 5, 1, 4, null, null, 3, 6 },
            false
        },
        new object[]
        {
            new int?[] { 2, 2, 2 },
            false
        },
        new object[]
        {
            new int?[] { 2147483647 },
            true
        }
    };
}