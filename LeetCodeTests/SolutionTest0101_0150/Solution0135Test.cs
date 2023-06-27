using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0135Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Candy_Greedy01(int[] ratings, int expected)
    {
        var solution = new Solution0135();
        var actual = solution.Candy_Greedy01(ratings);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void Candy_Greedy02(int[] ratings, int expected)
    {
        var solution = new Solution0135();
        var actual = solution.Candy_Greedy02(ratings);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 0, 2 },
            5
        },
        new object[]
        {
            new int[] { 1, 2, 2 },
            4
        }
    };
}