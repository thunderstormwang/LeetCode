using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500;

[TestFixture]
public class Solution0474Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindMaxForm(string[] strs, int m, int n, int expected)
    {
        var solution = new Solution0474();
        var actual = solution.FindMaxForm(strs, m, n);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new string[] { "10", "0001", "111001", "1", "0" },
            5,
            3,
            4
        },
        new object[]
        {
            new string[] { "10", "0", "1" },
            1,
            1,
            2
        }
    };
}