using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0437Test
{
    [TestCaseSource(nameof(TestCases))]
    public void PathSum_Ver1Test(int?[] array, int targetSum, int expected)
    {
        var root = Utility.BuildTree(array, 0);
        
        var solution = new Solution0437();
        var actual = solution.PathSum_Ver1(root, targetSum);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void PathSum_Ver2Test(int?[] array, int targetSum, int expected)
    {
        var root = Utility.BuildTree(array, 0);
        
        var solution = new Solution0437();
        var actual = solution.PathSum_Ver2(root, targetSum);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[]
            {
                10, 5, -3, 3, 2, null, 11, 3, -2, null, 1
            },
            8,
            3
        },
        new object[]
        {
            new int?[]
            {
                5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1
            },
            22,
            3
        },
        new object[]
        {
            new int?[]
            {
                1000000000, 1000000000, null, 294967296, null, 1000000000, null, 1000000000, null, 1000000000
            },
            0,
            0
        }
    };
}