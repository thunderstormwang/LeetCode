using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0338Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CountBits_Ver1Test(int n, int[] expected)
    {
        var solution = new Solution0338();

        var actual = solution.CountBits_Ver1(n);

        actual.Should().Equal(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CountBits_Ver2Test(int n, int[] expected)
    {
        var solution = new Solution0338();

        var actual = solution.CountBits_Ver2(n);

        actual.Should().Equal(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CountBits_Ver3Test(int n, int[] expected)
    {
        var solution = new Solution0338();

        var actual = solution.CountBits_Ver3(n);

        actual.Should().Equal(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            2,
            new int[] { 0, 1, 1 }
        },
        new object[]
        {
            5,
            new int[] { 0, 1, 1, 2, 1, 2 }
        }
    };
}