using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0084Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SubsetsWithDupTest(int[] heights, int expected)
    {
        var solution = new Solution0084();
        var actual = solution.LargestRectangleArea(heights);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 2,1,5,6,2,3 },
            10
        },
        new object[]
        {
            new int[] { 2,4 },
            4
        }
    };
}