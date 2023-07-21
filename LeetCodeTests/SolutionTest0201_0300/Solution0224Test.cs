using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0224Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CalculateTest(string s, int expected)
    {
        var solution = new Solution0224();
        var actual = solution.Calculate(s);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "1 + 1",
            2
        },
        new object[]
        {
            " 2-1 + 2 ",
            3
        },
        new object[]
        {
            "(1+(4+5+2)-3)+(6+8)",
            23
        },
        new object[]
        {
            "(10 - (3 + (3+4)))",
            0
        }
    };
}