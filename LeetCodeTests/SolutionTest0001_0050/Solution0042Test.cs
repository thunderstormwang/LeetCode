using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
public class Solution0042Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Trap_Stack_Ver1Test(int[] heights, int expected)
    {
        var solution = new Solution0042();

        var actual = solution.Trap_Stack_Ver1(heights);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void Trap_Stack_Ver2Test(int[] heights, int expected)
    {
        var solution = new Solution0042();

        var actual = solution.Trap_Stack_Ver2(heights);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 },
            6
        },
        new object[]
        {
            new int[] { 4, 2, 0, 3, 2, 5 },
            9
        },
        new object[]
        {
            new int[] { 7, 0, 9 },
            7
        },
        new object[]
        {
            new int[] { 5, 4, 3 },
            0
        },
        new object[]
        {
            new int[] { 3, 4, 5 },
            0
        }
    };
}