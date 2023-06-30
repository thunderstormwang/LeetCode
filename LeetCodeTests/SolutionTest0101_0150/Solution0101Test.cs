using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0101Test
{
    [TestCaseSource(nameof(TestCases))]
    public void IsSymmetric_Ver1Test(int? [] array, bool expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0101();
        var actual = solution.IsSymmetric_Ver1(root);

        actual.Should().Be(expected);
    }
        
    [TestCaseSource(nameof(TestCases))]
    public void IsSymmetric_Ver2Test(int? [] array, bool expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0101();
        var actual = solution.IsSymmetric_Ver2(root);

        actual.Should().Be(expected);
    }
        
    [TestCaseSource(nameof(TestCases))]
    public void IsSymmetric_Ver3Test(int? [] array, bool expected)
    {
        var root = Utility.BuildTree(array, 0);

        var solution = new Solution0101();
        var actual = solution.IsSymmetric_Ver3(root);

        actual.Should().Be(expected);
    }
        
    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 1, 2, 2, 3, 4, 4, 3 },
            true
        },
        new object[]
        {
            new int?[] { 1, 2, 2, null, 3, null, 3 },
            false
        }
    };
}