using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0207Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CanFinishTest(int numCourses, int[][] prerequisites, bool expected)
    {
        var solution = new Solution0207();
        var actual = solution.CanFinish(numCourses, prerequisites);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CanFinish_Ver2Test(int numCourses, int[][] prerequisites, bool expected)
    {
        var solution = new Solution0207();
        var actual = solution.CanFinish_Ver2(numCourses, prerequisites);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CanFinish_Ver3Test(int numCourses, int[][] prerequisites, bool expected)
    {
        var solution = new Solution0207();
        var actual = solution.CanFinish_Ver3(numCourses, prerequisites);

        actual.Should().Be(expected);
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
            true
        },
        new object[]
        {
            2,
            new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 0, 1 }
            },
            false
        },
        new object[]
        {
            8,
            new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 2, 6 },
                new int[] { 1, 7 },
                new int[] { 5, 1 },
                new int[] { 6, 4 },
                new int[] { 7, 0 },
                new int[] { 0, 5 },
            },
            false
        },
        new object[]
        {
            8,
            new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 2, 6 },
                new int[] { 1, 7 },
                new int[] { 6, 4 },
                new int[] { 7, 0 },
                new int[] { 0, 5 },
            },
            true
        }
    };
}