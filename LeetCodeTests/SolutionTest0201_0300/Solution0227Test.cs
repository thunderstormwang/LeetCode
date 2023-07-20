using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0227Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CalculateTest(string s, int expected)
    {
        var solution = new Solution0227();
        var actual = solution.Calculate(s);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "3+2*2",
            7
        },
        new object[]
        {
            "3/2 ",
            1
        },
        new object[]
        {
            "3+5 / 2 ",
            5
        },
        new object[]
        {
            "0*1",
            0
        }
    };
}