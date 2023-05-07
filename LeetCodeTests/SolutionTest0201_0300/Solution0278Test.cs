using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0278Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FirstBadVersionTest(int n, int firstBadVersion, int expected)
    {
        var solution = new Solution0278(firstBadVersion);
        var actual = solution.FirstBadVersion(n);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            5,
            4,
            4
        },
        new object[]
        {
            1,
            1,
            1
        },
        new object[]
        {
            5,
            5,
            5
        },
        new object[]
        {
            5,
            3,
            3
        },
        new object[]
        {
            5,
            2,
            2
        },
        new object[]
        {
            5,
            1,
            1
        }
    };
}