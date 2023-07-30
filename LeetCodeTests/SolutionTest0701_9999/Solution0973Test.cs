using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0973Test
{
    [TestCaseSource(nameof(TestCases))]
    public void KClosest_Ver1Test(int[][] points, int k, int[][] expected)
    {
        var solution = new Solution0973();

        var actual = solution.KClosest_Ver1(points, k);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void KClosest_Ver2Test(int[][] points, int k, int[][] expected)
    {
        var solution = new Solution0973();

        var actual = solution.KClosest_Ver2(points, k);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new[] { 1, 3 },
                new[] { -2, 2 }
            },
            1,
            new int[][]
            {
                new[] { -2, 2 }
            }
        },
        new object[]
        {
            new int[][]
            {
                new[] { 3, 3 },
                new[] { 5, -1 },
                new[] { -2, 4 }
            },
            2,
            new int[][]
            {
                new[] { 3, 3 },
                new[] { -2, 4 }
            }
        }
    };
}