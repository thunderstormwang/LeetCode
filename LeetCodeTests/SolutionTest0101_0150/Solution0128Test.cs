using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0128Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LongestConsecutive_Ver1Test(int[] nums, int expected)
    {
        var solution = new Solution0128();
        var actual = solution.LongestConsecutive_Ver1(nums);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void LongestConsecutive_Ver2Test(int[] nums, int expected)
    {
        var solution = new Solution0128();
        var actual = solution.LongestConsecutive_Ver2(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 100, 4, 200, 1, 3, 2 },
            4
        },
        new object[]
        {
            new int[] {0, 3, 7, 2, 5, 8, 4, 6, 0, 1 },
            9
        },
        new object[]
        {
            new int[] { 0, 3, 2, 1, 4, 4, 6, 1, 1, 2, 3 },
            5
        },
        new object[]
        {
            new int[] { 0, 3, 6, 3 },
            1
        }
    };
}