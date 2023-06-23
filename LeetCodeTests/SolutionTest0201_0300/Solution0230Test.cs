using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0230Test
{
    [TestCaseSource(nameof(TestCases))]
    public void KthSmallest_Ver1Test(int?[] inputArray, int k, int expected)
    {
        var root = Utility.BuildTree(inputArray, 0);

        var solution = new Solution0230();
        var actual = solution.KthSmallest_Ver1(root, k);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void KthSmallest_Ver2Test(int?[] inputArray, int k, int expected)
    {
        var root = Utility.BuildTree(inputArray, 0);

        var solution = new Solution0230();
        var actual = solution.KthSmallest_Ver2(root, k);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 3, 1, 4, null, 2 },
            1,
            1
        },
        new object[]
        {
            new int?[] { 5, 3, 6, 2, 4, null, null, 1 },
            3,
            3
        }
    };
}