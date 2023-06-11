using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0210Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindOrder_Ver1Test(int numCourses, int[][] prerequisites, int[] expected)
    {
        var solution = new Solution0210();
        var actual = solution.FindOrder_Ver1(numCourses, prerequisites);

        actual.Should().BeEquivalentTo(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void FindOrder_Ver2Test(int numCourses, int[][] prerequisites, int[] expected)
    {
        var solution = new Solution0210();
        var actual = solution.FindOrder_Ver2(numCourses, prerequisites);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            2,
            new int[][]
            {
                new int[] { 1, 0 }
            },
            new int[] { 0, 1 }
        },
        new object[]
        {
            4,
            new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 2, 0 },
                new int[] { 3, 1 },
                new int[] { 3, 2 }
            },
            new int[] { 0, 2, 1, 3 }
        },
        new object[]
        {
            1,
            new int[][]
            {
            },
            new int[] { 0 }
        }
    };
}