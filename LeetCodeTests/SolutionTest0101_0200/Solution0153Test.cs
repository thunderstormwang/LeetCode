using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
[Category("SolutionTest0101_0200")]
public class Solution0153Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindMin_Ver1Test(int[] array, int expected)
    {
        var solution = new Solution0153();
        var actual = solution.FindMin_Ver1(array);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void FindMin_Ver2Test(int[] array, int expected)
    {
        var solution = new Solution0153();
        var actual = solution.FindMin_Ver2(array);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 3, 4, 5, 1, 2 },
            1,
        },
        new object[]
        {
            new int[] { 4, 5, 6, 7, 0, 1, 2 },
            0,
        },
        new object[]
        {
            new int[] { 11, 13, 15, 17 },
            11,
        }
    };
}