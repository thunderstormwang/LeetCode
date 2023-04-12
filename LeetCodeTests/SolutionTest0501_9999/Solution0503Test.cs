using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
[Category("SolutionTest0501_9999")]
public class Solution0503Test
{
    [TestCaseSource(nameof(TestCases))]
    public void NextGreaterElementTest(int[] nums, int[] expected)
    {
        var solution = new Solution0503();
        var actual = solution.NextGreaterElements(nums);

        actual.Should().Equal(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 1 },
            new int[] { 2, -1, 2 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 3 },
            new int[] { 2, 3, 4, -1, 4 }
        },
        new object[]
        {
            new int[] { 100,1,11,1,120,111,123,1,-1,-100 },
            new int[] { 120,11,120,120,123,123,-1,100,100,100 }
        }
    };
}